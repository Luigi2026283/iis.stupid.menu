const express = require("express");
const defaultMenu = require("../data/defaultMenu");
const { withDb, nowIso } = require("../db/store");
const createAuthMiddleware = require("../middleware/auth");

module.exports = function menuRoutes(config) {
  const router = express.Router();
  const auth = createAuthMiddleware(config);

  router.get("/mods", (_req, res) => {
    return res.json(defaultMenu);
  });

  router.get("/state", auth, (req, res) => {
    const state = withDb(config, (db) => {
      let userState = db.menuStates.find((s) => s.userId === req.userId);
      if (!userState) {
        userState = { userId: req.userId, enabledMods: [], updatedAt: nowIso() };
        db.menuStates.push(userState);
      }
      return userState;
    });

    return res.json({ state });
  });

  router.put("/state", auth, (req, res) => {
    const enabledMods = Array.isArray(req.body?.enabledMods)
      ? req.body.enabledMods.filter((m) => typeof m === "string")
      : null;
    if (!enabledMods) {
      return res.status(400).json({ error: "enabledMods must be an array of strings." });
    }

    const state = withDb(config, (db) => {
      let userState = db.menuStates.find((s) => s.userId === req.userId);
      if (!userState) {
        userState = { userId: req.userId, enabledMods: [], updatedAt: nowIso() };
        db.menuStates.push(userState);
      }

      userState.enabledMods = [...new Set(enabledMods)];
      userState.updatedAt = nowIso();
      return userState;
    });

    return res.json({ state });
  });

  return router;
};
