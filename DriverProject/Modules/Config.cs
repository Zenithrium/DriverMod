﻿using BepInEx.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using RiskOfOptions;
using RiskOfOptions.Options;
using RiskOfOptions.OptionConfigs;

namespace RobDriver.Modules
{
    internal static class Config
    {
        public static ConfigFile myConfig;

        public static ConfigEntry<bool> autoFocus;
        public static ConfigEntry<bool> sharedPickupVisuals;
        public static ConfigEntry<bool> oldPickupModel;
        public static ConfigEntry<float> baseDropRate;
        public static ConfigEntry<bool> weaponCallouts;
        public static ConfigEntry<bool> backupMagExtendDuration;
        public static ConfigEntry<bool> classicDodgeSound;
        public static ConfigEntry<bool> enablePistolUpgrade;
        public static ConfigEntry<bool> enablePickupNotifications;
        public static ConfigEntry<bool> predatoryOnHead;
        public static ConfigEntry<bool> cursed;

        public static ConfigEntry<float> baseHealth;
        public static ConfigEntry<float> healthGrowth;
        public static ConfigEntry<float> baseDamage;
        public static ConfigEntry<float> damageGrowth;
        public static ConfigEntry<float> baseArmor;
        public static ConfigEntry<float> armorGrowth;
        public static ConfigEntry<float> baseMovementSpeed;
        public static ConfigEntry<float> baseCrit;
        public static ConfigEntry<float> baseRegen;

        public static ConfigEntry<KeyboardShortcut> restKey;
        public static ConfigEntry<KeyboardShortcut> tauntKey;
        public static ConfigEntry<KeyboardShortcut> danceKey;

        public static List<WeaponConfigBinding> weaponConfigBinding = new List<WeaponConfigBinding>();

        public struct WeaponConfigBinding
        {
            public string identifier;
            public ConfigEntry<bool> enabled;
            public ConfigEntry<int> shotCount;
        }

        internal static void ReadConfig()
        {
            #region General
            autoFocus
             = Config.BindAndOptions("01 - General",
             "Focus Auto Charge",
             false,
             "If set to true, Focus will always charge up before firing a shot. Take control of your runs with the illusion of skill! (Client-side)");

            sharedPickupVisuals
 = Config.BindAndOptions("01 - General",
 "Shared Pickup Visuals",
 true,
 "If set to false, weapon pickups will only be visible while playing Driver. Setting this to true lets every character see them. (Client-side)");

            oldPickupModel
= Config.BindAndOptions("01 - General",
"Old Weapon Pickup Model",
false,
"If set to true, uses the old goofy crate pickups instead of briefcases. (Client-side)");

            baseDropRate
= Config.BindAndOptionsSlider("01 - General",
"Base Drop Rate",
7f,
"Base chance for weapons to drop on kill", 0f, 100f);

            weaponCallouts
= Config.BindAndOptions("01 - General",
"Weapon Pickup Callouts",
false,
"If set to true, Driver will call out the weapons he picks up. (Client-side)");

            backupMagExtendDuration
= Config.BindAndOptions("01 - General",
"Backup Magazine Duration Extension",
false,
"If set to true, Backup Magazines will extend the duration of weapon pickups by 0.5s.");

            classicDodgeSound
= Config.BindAndOptions("01 - General",
"Classic Dodge Sound",
false,
"If set to true, will use the old Combat Slide SFX. (Client-side)");

            enablePistolUpgrade
= Config.BindAndOptions("01 - General",
"Enable Pistol Upgrade",
true,
"If set to false, will stop Pistol from upgrading itself for run-ending boss fights.");

            enablePickupNotifications
= Config.BindAndOptions("01 - General",
"Enable Weapon Pickup Notifications",
true,
"If set to false, will disable the notifications from picking up weapons. (Client-side)");

            predatoryOnHead
= Config.BindAndOptions("01 - General",
"Predatory Instincts On Head",
false,
"If set to true, the item display for Predatory Instincts will be moved to the head like other survivors. (Client-side)", true);

            cursed
= Config.BindAndOptions("01 - General",
"Cursed",
false,
"Enables unstable and stupid content", true);
            #endregion

            #region Emotes
            restKey
                = Config.BindAndOptions("02 - Keybinds",
                         "Rest Emote",
                         new KeyboardShortcut(KeyCode.Alpha1),
                         "Key used to Rest");
            tauntKey
                = Config.BindAndOptions("02 - Keybinds",
                                     "Salute Emote",
                                     new KeyboardShortcut(KeyCode.Alpha2),
                                     "Key used to Taunt");

            danceKey
                = Config.BindAndOptions("02 - Keybinds",
                                     "Dance Emote",
                                     new KeyboardShortcut(KeyCode.Alpha3),
                                     "Key used to Dance");
            #endregion

            #region Stats
            baseHealth
                = Config.BindAndOptionsSlider("03 - Character Stats",
                         "Base Health",
                         110f,
                         "", 1f, 500f, true);
            healthGrowth
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Health Growth",
                                     33f,
                                     "", 0f, 100f, true);
            baseRegen
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Base Health Regen",
                                     1.5f,
                                     "", 0f, 5f, true);
            baseArmor
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Base Armor",
                                     0f,
                                     "", 0f, 20f, true);
            armorGrowth
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Armor Growth",
                                     0f,
                                     "", 0f, 2f, true);
            baseDamage
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Base Damage",
                                     12f,
                                     "", 1f, 24f, true);
            damageGrowth
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Damage Growth",
                                     2.4f,
                                     "", 0f, 5f, true);
            baseMovementSpeed
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Base Movement Speed",
                                     7f,
                                     "", 0f, 14f, true);
            baseCrit
                = Config.BindAndOptionsSlider("03 - Character Stats",
                                     "Base Crit",
                                     1f,
                                     "", 0f, 100f, true);
            #endregion
        }

        public static void InitWeaponConfig(DriverWeaponDef weaponDef)
        {
            if (!weaponDef) return;
            if (string.IsNullOrWhiteSpace(weaponDef.configIdentifier)) return;

            var x = Config.BindAndOptionsSlider("04 - Weapons",
 weaponDef.configIdentifier + " - Base Ammo",
 weaponDef.shotCount,
 "How many shots this weapon can fire without any bonus attack speed.", 0, 200);

            var y = Config.BindAndOptions("04 - Weapons",
weaponDef.configIdentifier + " - Enabled",
true,
"Set to false to remove this weapon from the drop pool.");


            weaponConfigBinding.Add(new WeaponConfigBinding
            {
                identifier = weaponDef.configIdentifier,
                enabled = y,
                shotCount = x
            });
        }

        public static bool GetWeaponConfig(DriverWeaponDef weaponDef)
        {
            foreach (WeaponConfigBinding i in weaponConfigBinding)
            {
                if (i.identifier == weaponDef.configIdentifier)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool GetWeaponConfigEnabled(DriverWeaponDef weaponDef)
        {
            foreach (WeaponConfigBinding i in weaponConfigBinding)
            {
                if (i.identifier == weaponDef.configIdentifier)
                {
                    return i.enabled.Value;
                }
            }

            return true;
        }

        public static int GetWeaponConfigShotCount(DriverWeaponDef weaponDef)
        {
            foreach (WeaponConfigBinding i in weaponConfigBinding)
            {
                if (i.identifier == weaponDef.configIdentifier)
                {
                    return i.shotCount.Value;
                }
            }

            return 0;
        }

        public static void InitROO(Sprite modSprite, string modDescription)
        {
            if (DriverPlugin.rooInstalled) _InitROO(modSprite, modDescription);
        }

        public static void _InitROO(Sprite modSprite, string modDescription)
        {
            ModSettingsManager.SetModIcon(modSprite);
            ModSettingsManager.SetModDescription(modDescription);
        }

        public static ConfigEntry<T> BindAndOptions<T>(string section, string name, T defaultValue, string description = "", bool restartRequired = false)
        {
            if (string.IsNullOrEmpty(description))
            {
                description = name;
            }

            if (restartRequired)
            {
                description += " (restart required)";
            }

            ConfigEntry<T> configEntry = myConfig.Bind(section, name, defaultValue, description);

            if (DriverPlugin.rooInstalled)
            {
                TryRegisterOption(configEntry, restartRequired);
            }

            return configEntry;
        }

        public static ConfigEntry<float> BindAndOptionsSlider(string section, string name, float defaultValue, string description = "", float min = 0, float max = 20, bool restartRequired = false)
        {
            if (string.IsNullOrEmpty(description))
            {
                description = name;
            }

            description += " (Default: " + defaultValue + ")";

            if (restartRequired)
            {
                description += " (restart required)";
            }

            ConfigEntry<float> configEntry = myConfig.Bind(section, name, defaultValue, description);

            if (DriverPlugin.rooInstalled)
            {
                TryRegisterOptionSlider(configEntry, min, max, restartRequired);
            }

            return configEntry;
        }

        public static ConfigEntry<int> BindAndOptionsSlider(string section, string name, int defaultValue, string description = "", int min = 0, int max = 20, bool restartRequired = false)
        {
            if (string.IsNullOrEmpty(description))
            {
                description = name;
            }

            description += " (Default: " + defaultValue + ")";

            if (restartRequired)
            {
                description += " (restart required)";
            }

            ConfigEntry<int> configEntry = myConfig.Bind(section, name, defaultValue, description);

            if (DriverPlugin.rooInstalled)
            {
                TryRegisterOptionSlider(configEntry, min, max, restartRequired);
            }

            return configEntry;
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static void TryRegisterOption<T>(ConfigEntry<T> entry, bool restartRequired)
        {
            if (entry is ConfigEntry<float>)
            {
                ModSettingsManager.AddOption(new SliderOption(entry as ConfigEntry<float>, new SliderConfig() { min = 0, max = 20, formatString = "{0:0.00}", restartRequired = restartRequired }));
            }
            if (entry is ConfigEntry<int>)
            {
                ModSettingsManager.AddOption(new IntSliderOption(entry as ConfigEntry<int>, restartRequired));
            }
            if (entry is ConfigEntry<bool>)
            {
                ModSettingsManager.AddOption(new CheckBoxOption(entry as ConfigEntry<bool>, restartRequired));
            }
            if (entry is ConfigEntry<KeyboardShortcut>)
            {
                ModSettingsManager.AddOption(new KeyBindOption(entry as ConfigEntry<KeyboardShortcut>, restartRequired));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static void TryRegisterOptionSlider(ConfigEntry<int> entry, int min, int max, bool restartRequired)
        {
            ModSettingsManager.AddOption(new IntSliderOption(entry as ConfigEntry<int>, new IntSliderConfig() { min = min, max = max, formatString = "{0:0.00}", restartRequired = restartRequired }));
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static void TryRegisterOptionSlider(ConfigEntry<float> entry, float min, float max, bool restartRequired)
        {
            ModSettingsManager.AddOption(new SliderOption(entry as ConfigEntry<float>, new SliderConfig() { min = min, max = max, formatString = "{0:0.00}", restartRequired = restartRequired }));
        }

        internal static ConfigEntry<bool> CharacterEnableConfig(string characterName)
        {
            return Config.BindAndOptions("01 - General",
                         "Enabled",
                         true,
                         "Set to false to disable this character", true);
        }

        internal static ConfigEntry<bool> ForceUnlockConfig(string characterName)
        {
            return Config.BindAndOptions("01 - General",
                         "Force Unlock",
                         false,
                         "Makes this character unlocked by default", true);
        }

        public static bool GetKeyPressed(ConfigEntry<KeyboardShortcut> entry)
        {
            foreach (var item in entry.Value.Modifiers)
            {
                if (!Input.GetKey(item))
                {
                    return false;
                }
            }
            return Input.GetKeyDown(entry.Value.MainKey);
        }
    }


    public class StageSpawnInfo 
    {
        private string stageName;
        private int minStages;

        public StageSpawnInfo(string stageName, int minStages) {
            this.stageName = stageName;
            this.minStages = minStages;
        }

        public string GetStageName() { return stageName; }
        public int GetMinStages() { return minStages; }
    }
}