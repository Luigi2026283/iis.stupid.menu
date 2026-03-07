const express = require("express");
const { withDb, nowIso } = require("../db/store");
const createAuthMiddleware = require("../middleware/auth");

module.exports = function settingsRoutes(config) {
  const router = express.Router();
  const auth = createAuthMiddleware(config);

  router.use(auth);

  router.get("/", (req, res) => {
    const settings = withDb(config, (db) => {
      let item = db.settings.find((s) => s.userId === req.userId);
      if (!item) {
        item = { userId: req.userId, values: {}, updatedAt: nowIso() };
        db.settings.push(item);
      }
      return item;
    });

    return res.json({ settings });
  });

  router.put("/", (req, res) => {
    const values = req.body?.values;
    if (!values || typeof values !== "object" || Array.isArray(values)) {
      return res.status(400).json({ error: "values must be an object." });
    }

    const settings = withDb(config, (db) => {
      let item = db.settings.find((s) => s.userId === req.userId);
      if (!item) {
        item = { userId: req.userId, values: {}, updatedAt: nowIso() };
        db.settings.push(item);
      }

      item.values = { ...item.values, ...values };
      item.updatedAt = nowIso();
      return item;
    });

    return res.json({ settings });
  });

  return router;
};
