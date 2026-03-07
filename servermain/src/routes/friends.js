const express = require("express");
const { withDb, createId, nowIso } = require("../db/store");
const createAuthMiddleware = require("../middleware/auth");

function friendshipKey(a, b) {
  return [a, b].sort().join(":");
}

function toFriendDto(friendUser, presence) {
  return {
    id: friendUser.id,
    username: friendUser.username,
    displayName: friendUser.displayName,
    presence: presence || {
      status: "offline",
      roomId: null,
      platform: null,
      updatedAt: null,
    },
  };
}

module.exports = function friendRoutes(config) {
  const router = express.Router();
  const auth = createAuthMiddleware(config);

  router.use(auth);

  router.get("/", (req, res) => {
    const output = withDb(config, (db) => {
      const friendIds = db.friendships
        .filter((f) => f.userAId === req.userId || f.userBId === req.userId)
        .map((f) => (f.userAId === req.userId ? f.userBId : f.userAId));

      return friendIds
        .map((id) => {
          const friendUser = db.users.find((u) => u.id === id);
          if (!friendUser) return null;
          const presence = db.presence.find((p) => p.userId === id) || null;
          return toFriendDto(friendUser, presence);
        })
        .filter(Boolean);
    });

    return res.json({ friends: output });
  });

  router.get("/requests", (req, res) => {
    const requests = withDb(config, (db) =>
      db.friendRequests
        .filter((r) => r.toUserId === req.userId && r.status === "pending")
        .map((r) => {
          const from = db.users.find((u) => u.id === r.fromUserId);
          return {
            id: r.id,
            fromUserId: r.fromUserId,
            fromUsername: from ? from.username : "unknown",
            fromDisplayName: from ? from.displayName : "unknown",
            createdAt: r.createdAt,
          };
        }),
    );

    return res.json({ requests });
  });

  router.post("/request", (req, res) => {
    const toUsername = String(req.body?.toUsername || "").trim().toLowerCase();
    if (!toUsername) {
      return res.status(400).json({ error: "toUsername is required." });
    }

    const result = withDb(config, (db) => {
      const fromUser = db.users.find((u) => u.id === req.userId);
      const toUser = db.users.find((u) => u.username === toUsername);
      if (!fromUser) return { error: "Sender not found.", status: 404 };
      if (!toUser) return { error: "Target user not found.", status: 404 };
      if (toUser.id === fromUser.id) return { error: "Cannot add yourself.", status: 400 };

      const alreadyFriends = db.friendships.some(
        (f) => friendshipKey(f.userAId, f.userBId) === friendshipKey(fromUser.id, toUser.id),
      );
      if (alreadyFriends) return { error: "Already friends.", status: 409 };

      const alreadyPending = db.friendRequests.some(
        (r) =>
          r.status === "pending" &&
          friendshipKey(r.fromUserId, r.toUserId) === friendshipKey(fromUser.id, toUser.id),
      );
      if (alreadyPending) return { error: "Friend request already pending.", status: 409 };

      const reqObj = {
        id: createId("frq"),
        fromUserId: fromUser.id,
        toUserId: toUser.id,
        status: "pending",
        createdAt: nowIso(),
        updatedAt: nowIso(),
      };
      db.friendRequests.push(reqObj);
      return { request: reqObj };
    });

    if (result.error) return res.status(result.status).json({ error: result.error });
    return res.status(201).json(result);
  });

  router.post("/request/:requestId/accept", (req, res) => {
    const requestId = String(req.params.requestId || "");
    const result = withDb(config, (db) => {
      const request = db.friendRequests.find((r) => r.id === requestId);
      if (!request) return { error: "Request not found.", status: 404 };
      if (request.toUserId !== req.userId) return { error: "Forbidden.", status: 403 };
      if (request.status !== "pending") return { error: "Request already handled.", status: 409 };

      request.status = "accepted";
      request.updatedAt = nowIso();

      const exists = db.friendships.some(
        (f) => friendshipKey(f.userAId, f.userBId) === friendshipKey(request.fromUserId, request.toUserId),
      );
      if (!exists) {
        db.friendships.push({
          id: createId("fr"),
          userAId: request.fromUserId,
          userBId: request.toUserId,
          createdAt: nowIso(),
        });
      }

      return { ok: true };
    });

    if (result.error) return res.status(result.status).json({ error: result.error });
    return res.json({ success: true });
  });

  router.post("/request/:requestId/decline", (req, res) => {
    const requestId = String(req.params.requestId || "");
    const result = withDb(config, (db) => {
      const request = db.friendRequests.find((r) => r.id === requestId);
      if (!request) return { error: "Request not found.", status: 404 };
      if (request.toUserId !== req.userId) return { error: "Forbidden.", status: 403 };
      if (request.status !== "pending") return { error: "Request already handled.", status: 409 };

      request.status = "declined";
      request.updatedAt = nowIso();
      return { ok: true };
    });

    if (result.error) return res.status(result.status).json({ error: result.error });
    return res.json({ success: true });
  });

  router.delete("/:username", (req, res) => {
    const username = String(req.params.username || "").trim().toLowerCase();
    const result = withDb(config, (db) => {
      const user = db.users.find((u) => u.username === username);
      if (!user) return { error: "User not found.", status: 404 };

      const initial = db.friendships.length;
      db.friendships = db.friendships.filter(
        (f) => friendshipKey(f.userAId, f.userBId) !== friendshipKey(req.userId, user.id),
      );
      if (db.friendships.length === initial) return { error: "Friendship not found.", status: 404 };

      return { ok: true };
    });

    if (result.error) return res.status(result.status).json({ error: result.error });
    return res.json({ success: true });
  });

  return router;
};
