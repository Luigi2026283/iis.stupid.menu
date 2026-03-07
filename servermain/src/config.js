const path = require("path");
const fs = require("fs");
const dotenv = require("dotenv");

dotenv.config();

const envFile = path.join(__dirname, "../.env");

function readRuntimeEnv() {
  try {
    if (fs.existsSync(envFile)) {
      const envRaw = fs.readFileSync(envFile, "utf8");
      return dotenv.parse(envRaw);
    }
  } catch {
    // Ignore parse/file errors and fallback to process.env.
  }

  return process.env;
}

function readRuntimeMotd() {
  const env = readRuntimeEnv();
  const value = String(env.MOTD_MESSAGE || process.env.MOTD_MESSAGE || "").trim();
  return (
    value ||
    "The server is currently still in development. Version: 8.3.5. Best regards, Luigi_2026_."
  );
}

module.exports = {
  port: Number(process.env.PORT || 8080),
  jwtSecret: process.env.JWT_SECRET || "dev_secret_change_me",
  tokenExpiresIn: process.env.TOKEN_EXPIRES_IN || "30d",
  serverVersion: process.env.SERVER_VERSION || "8.3.5",
  motdMessage: readRuntimeMotd(),
  readRuntimeMotd,
  dataDir: path.join(__dirname, "../data"),
  envFile,
};
