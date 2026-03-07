const express = require("express");
const { nowIso } = require("../db/store");

module.exports = function systemRoutes(config) {
  const router = express.Router();

  router.get("/health", (_req, res) => {
    return res.json({ ok: true, timestamp: nowIso() });
  });

  router.get("/version", (_req, res) => {
    return res.json({ version: config.serverVersion });
  });

  router.get("/motd", (_req, res) => {
    return res.json({
      motd: {
        message: config.readRuntimeMotd(),
        updatedAt: nowIso(),
        source: ".env",
      },
    });
  });

  return router;
};
