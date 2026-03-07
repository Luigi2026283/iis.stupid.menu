const fs = require("fs");
const path = require("path");
const { v4: uuidv4 } = require("uuid");

const DB_FILE_NAME = "db.json";

const nowIso = () => new Date().toISOString();

function createBaseDb(config) {
  return {
    users: [],
    friendRequests: [],
    friendships: [],
    menuStates: [],
    settings: [],
    presence: [],
    motd: {
      message: config.motdMessage,
      updatedAt: nowIso(),
      source: "local",
    },
  };
}

function ensureDb(config) {
  if (!fs.existsSync(config.dataDir)) {
    fs.mkdirSync(config.dataDir, { recursive: true });
  }

  const dataFile = path.join(config.dataDir, DB_FILE_NAME);
  if (!fs.existsSync(dataFile)) {
    fs.writeFileSync(dataFile, JSON.stringify(createBaseDb(config), null, 2), "utf8");
    return dataFile;
  }

  const existing = JSON.parse(fs.readFileSync(dataFile, "utf8"));
  const merged = {
    ...createBaseDb(config),
    ...existing,
    motd: {
      message:
        existing.motd && typeof existing.motd.message === "string"
          ? existing.motd.message
          : config.motdMessage,
      updatedAt:
        existing.motd && typeof existing.motd.updatedAt === "string"
          ? existing.motd.updatedAt
          : nowIso(),
      source: "local",
    },
  };

  fs.writeFileSync(dataFile, JSON.stringify(merged, null, 2), "utf8");
  return dataFile;
}

function readDb(config) {
  const file = path.join(config.dataDir, DB_FILE_NAME);
  return JSON.parse(fs.readFileSync(file, "utf8"));
}

function writeDb(config, db) {
  const file = path.join(config.dataDir, DB_FILE_NAME);
  fs.writeFileSync(file, JSON.stringify(db, null, 2), "utf8");
}

function withDb(config, mutator) {
  const db = readDb(config);
  const result = mutator(db);
  writeDb(config, db);
  return result;
}

function createId(prefix) {
  return `${prefix}_${uuidv4().replace(/-/g, "")}`;
}

module.exports = {
  ensureDb,
  readDb,
  writeDb,
  withDb,
  createId,
  nowIso,
};
