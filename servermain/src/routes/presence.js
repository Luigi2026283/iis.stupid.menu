const express = require("express");
const { withDb, nowIso } = require("../db/store");
const createAuthMiddleware = require("../middleware/auth");

module.exports = function presenceRoutes(config) {
  const router = express.Router();
  const auth = createAuthMiddleware(config);

  router.use(auth);

  router.post("/", (req, res) => {
    const status = String(req.body?.status || "online").trim().toLowerCase();
    const roomIdRaw = req.body?.roomId;
    const platformRaw = req.body?.platform;
    const roomId = roomIdRaw == null ? null : String(roomIdRaw).trim();
    const platform = platformRaw == null ? null : String(platformRaw).trim();

    if (!["online", "offline", "in_room", "busy"].includes(status)) {
      return res.status(400).json({ error: "Invalid status." });
    }

    const presence = withDb(config, (db) => {
      let p = db.presence.find((item) => item.userId === req.userId);
      if (!p) {
        p = {
          userId: req.userId,
          status: "offline",
          roomId: null,
          platform: null,
          updatedAt: nowIso(),
        };
        db.presence.push(p);
      }

      p.status = status;
      p.roomId = roomId;
      p.platform = platform;
      p.updatedAt = nowIso();
      return p;
    });

    return res.json({ presence });
  });

  return router;
};
