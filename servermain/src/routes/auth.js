const express = require("express");
const bcrypt = require("bcryptjs");
const jwt = require("jsonwebtoken");
const { withDb, createId, nowIso } = require("../db/store");
const createAuthMiddleware = require("../middleware/auth");

function sanitizeUser(user) {
  return {
    id: user.id,
    username: user.username,
    displayName: user.displayName,
    createdAt: user.createdAt,
  };
}

function createToken(config, userId) {
  return jwt.sign({ userId }, config.jwtSecret, { expiresIn: config.tokenExpiresIn });
}

module.exports = function authRoutes(config) {
  const router = express.Router();
  const auth = createAuthMiddleware(config);

  router.post("/register", async (req, res) => {
    const username = String(req.body?.username || "").trim().toLowerCase();
    const password = String(req.body?.password || "");
    const displayNameInput = String(req.body?.displayName || "").trim();
    const displayName = displayNameInput.length > 0 ? displayNameInput : username;

    if (!username || username.length < 3) {
      return res.status(400).json({ error: "Username must be at least 3 characters." });
    }
    if (!password || password.length < 6) {
      return res.status(400).json({ error: "Password must be at least 6 characters." });
    }

    const existing = withDb(config, (db) => db.users.find((u) => u.username === username));
    if (existing) {
      return res.status(409).json({ error: "Username already exists." });
    }

    const passwordHash = await bcrypt.hash(password, 10);
    let newUser;
    withDb(config, (db) => {
      newUser = {
        id: createId("usr"),
        username,
        displayName,
        passwordHash,
        createdAt: nowIso(),
      };
      db.users.push(newUser);
      db.menuStates.push({ userId: newUser.id, enabledMods: [], updatedAt: nowIso() });
      db.settings.push({ userId: newUser.id, values: {}, updatedAt: nowIso() });
      db.presence.push({
        userId: newUser.id,
        status: "offline",
        roomId: null,
        platform: null,
        updatedAt: nowIso(),
      });
    });

    return res.status(201).json({
      token: createToken(config, newUser.id),
      user: sanitizeUser(newUser),
    });
  });

  router.post("/login", async (req, res) => {
    const username = String(req.body?.username || "").trim().toLowerCase();
    const password = String(req.body?.password || "");

    if (!username || !password) {
      return res.status(400).json({ error: "Username and password are required." });
    }

    const user = withDb(config, (db) => db.users.find((u) => u.username === username));
    if (!user) {
      return res.status(401).json({ error: "Invalid username or password." });
    }

    const ok = await bcrypt.compare(password, user.passwordHash);
    if (!ok) {
      return res.status(401).json({ error: "Invalid username or password." });
    }

    return res.json({
      token: createToken(config, user.id),
      user: sanitizeUser(user),
    });
  });

  router.get("/me", auth, (req, res) => {
    const user = withDb(config, (db) => db.users.find((u) => u.id === req.userId));
    if (!user) {
      return res.status(404).json({ error: "User not found." });
    }
    return res.json({ user: sanitizeUser(user) });
  });

  return router;
};
