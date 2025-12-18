# Spawn Full Health

A simple Rust (uMod/Oxide) plugin that restores a player’s health, hydration, and calories every time they respawn.

## 📌 Features

- Sets player health on respawn
- Refills hydration
- Refills calories
- Lightweight and performance-friendly
- No configuration files required

## 📦 Plugin Information

- **Name:** Spawn Full Health  
- **Author:** mythical.dev  
- **Version:** 1.0.0  
- **Game:** Rust  
- **Framework:** uMod / Oxide  

## 🔧 How It Works

When a player respawns, the plugin automatically:
- Sets health to **100**
- Sets hydration to **250**
- Sets calories to **500**

## ⚙️ Customization

You can easily change the values by editing the plugin:

```csharp
player.health = 100f;
player.metabolism.hydration.value = 250f;
player.metabolism.calories.value = 500f;
