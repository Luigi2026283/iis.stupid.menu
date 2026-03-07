# servermain

Node.js server scaffold for the full menu backend:

- authentication (register/login/JWT)
- friend system (requests/accept/decline/remove/list)
- menu categories/mod list + per-user enabled mod state
- per-user settings storage
- presence/status updates
- MOTD + server version endpoints

## Quick Start

1. `cd servermain`
2. `npm install`
3. `copy .env.example .env` (Windows) and edit values
4. `npm run dev`

Server starts on `http://localhost:8080` by default.

## API Prefix

All routes use `/api/...`

- `GET /api/system/health`
- `GET /api/system/version`
- `GET /api/system/motd`
- `POST /api/auth/register`
- `POST /api/auth/login`
- `GET /api/auth/me`
- `GET /api/friends`
- `GET /api/friends/requests`
- `POST /api/friends/request`
- `POST /api/friends/request/:requestId/accept`
- `POST /api/friends/request/:requestId/decline`
- `DELETE /api/friends/:username`
- `GET /api/menu/mods`
- `GET /api/menu/state`
- `PUT /api/menu/state`
- `GET /api/settings`
- `PUT /api/settings`
- `POST /api/presence`

Compatibility endpoints used by the existing in-game menu loader:

- `GET /serverdata`
- `POST /telemetry`
- `POST /syncdata`
- `POST /reportban`
- `POST /vote`

## Storage

This scaffold stores data in `servermain/data/db.json` for simplicity.
