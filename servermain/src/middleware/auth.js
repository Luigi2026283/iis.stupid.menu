const jwt = require("jsonwebtoken");

function createAuthMiddleware(config) {
  return function auth(req, res, next) {
    const header = req.headers.authorization || "";
    const [scheme, token] = header.split(" ");

    if (scheme !== "Bearer" || !token) {
      return res.status(401).json({ error: "Missing or invalid bearer token." });
    }

    try {
      const payload = jwt.verify(token, config.jwtSecret);
      req.userId = payload.userId;
      return next();
    } catch {
      return res.status(401).json({ error: "Invalid or expired token." });
    }
  };
}

module.exports = createAuthMiddleware;
