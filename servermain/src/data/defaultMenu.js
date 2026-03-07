module.exports = {
  categories: [
    {
      id: "room_mods",
      name: "Room Mods",
      mods: [
        { id: "disconnect", name: "Disconnect", togglable: false },
        { id: "reconnect", name: "Reconnect", togglable: false },
        { id: "join_random", name: "Join Random", togglable: false },
      ],
    },
    {
      id: "important_mods",
      name: "Important Mods",
      mods: [
        { id: "anti_ban", name: "Anti Ban", togglable: true },
        { id: "safe_mode", name: "Safe Mode", togglable: true },
      ],
    },
    {
      id: "safety_mods",
      name: "Safety Mods",
      mods: [
        { id: "anti_report", name: "Anti Report", togglable: true },
        { id: "hide_name", name: "Hide Name", togglable: true },
      ],
    },
    {
      id: "movement_mods",
      name: "Movement Mods",
      mods: [
        { id: "speed_boost", name: "Speed Boost", togglable: true },
        { id: "platforms", name: "Platforms", togglable: true },
        { id: "long_arms", name: "Long Arms", togglable: true },
      ],
    },
    {
      id: "visual_mods",
      name: "Visual Mods",
      mods: [
        { id: "night_mode", name: "Night Mode", togglable: true },
        { id: "fullbright", name: "Fullbright", togglable: true },
      ],
    },
    {
      id: "fun_mods",
      name: "Fun Mods",
      mods: [
        { id: "soundboard", name: "Soundboard", togglable: true },
        { id: "random_name", name: "Random Name", togglable: false },
      ],
    },
    {
      id: "menu_settings",
      name: "Menu Settings",
      mods: [
        { id: "change_theme", name: "Change Theme", togglable: false },
        { id: "change_font", name: "Change Font", togglable: false },
        { id: "change_pc_gui_bg", name: "Change PC GUI Background", togglable: false },
      ],
    },
  ],
};
