const express = require("express");
const cors = require("cors");
const helmet = require("helmet");
const morgan = require("morgan");

const config = require("./config");
const { ensureDb } = require("./db/store");

const authRoutes = require("./routes/auth");
const friendRoutes = require("./routes/friends");
const menuRoutes = require("./routes/menu");
const settingsRoutes = require("./routes/settings");
const presenceRoutes = require("./routes/presence");
const systemRoutes = require("./routes/system");

ensureDb(config);

const app = express();

app.use(helmet());
app.use(cors());
app.use(express.json({ limit: "1mb" }));
app.use(morgan("dev"));

app.use("/api/system", systemRoutes(config));
app.use("/api/auth", authRoutes(config));
app.use("/api/friends", friendRoutes(config));
app.use("/api/menu", menuRoutes(config));
app.use("/api/settings", settingsRoutes(config));
app.use("/api/presence", presenceRoutes(config));

// Compatibility endpoints for the in-menu ServerData loader.
const voteState = { aVotes: 0, bVotes: 0 };

app.get("/serverdata", (_req, res) => {
  const runtimeMotd = config.readRuntimeMotd();

  return res.json({
    "discord-invite": "https://discord.gg/iistupidmenu",
    motd: runtimeMotd,
    "min-version": "8.3.5",
    "menu-version": config.serverVersion,
    "min-console-version": "0.0.0",
    admins: [],
    "super-admins": [],
    patreon: [],
    poll: "Which feature should be built next?",
    "option-a": "More PC GUI options",
    "option-b": "More friend system tools",
    "detected-mods": [],
  });
});

app.post("/telemetry", (_req, res) => {
  return res.json({ success: true });
});

app.post("/syncdata", (_req, res) => {
  return res.json({ success: true });
});

app.post("/reportban", (_req, res) => {
  return res.json({ success: true });
});

app.post("/vote", (req, res) => {
  const option = String(req.body?.option || "").trim();
  if (option === "a-votes") voteState.aVotes += 1;
  if (option === "b-votes") voteState.bVotes += 1;

  return res.json({
    "a-votes": voteState.aVotes,
    "b-votes": voteState.bVotes,
  });
});

app.use((_req, res) => {
  return res.status(404).json({ error: "Route not found." });
});

app.use((err, _req, res, _next) => {
  const status = Number(err?.status || 500);
  const message = err?.message || "Unexpected server error.";
  return res.status(status).json({ error: message });
});

app.listen(config.port, () => {
  // eslint-disable-next-line no-console
  console.log(`servermain listening on http://localhost:${config.port}`);
});
