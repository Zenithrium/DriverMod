﻿using System.Reflection;
using R2API;
using UnityEngine;
using UnityEngine.Networking;
using RoR2;
using System.IO;
using RoR2.Audio;
using System.Collections.Generic;
using RoR2.Projectile;
using UnityEngine.AddressableAssets;
using TMPro;
using RoR2.UI;
using UnityEngine.UI;
using RobDriver.Modules.Components;

namespace RobDriver.Modules
{
    internal static class Assets
    {
        internal static AssetBundle mainAssetBundle;

        internal static Shader hotpoo = Resources.Load<Shader>("Shaders/Deferred/HGStandard");
        internal static Material commandoMat;

        internal static List<EffectDef> effectDefs = new List<EffectDef>();
        internal static List<NetworkSoundEventDef> networkSoundEventDefs = new List<NetworkSoundEventDef>();

        internal static NetworkSoundEventDef hammerImpactSoundDef;

        public static GameObject jammedEffectPrefab;
        public static GameObject upgradeEffectPrefab;
        public static GameObject stunGrenadeModelPrefab;

        public static GameObject pistolAimCrosshairPrefab;
        public static GameObject bazookaCrosshairPrefab;
        public static GameObject rocketLauncherCrosshairPrefab;
        public static GameObject grenadeLauncherCrosshairPrefab;
        public static GameObject needlerCrosshairPrefab;
        public static GameObject circleCrosshairPrefab;

        public static GameObject weaponNotificationPrefab;

        public static Mesh pistolMesh;
        public static Mesh goldenGunMesh;
        public static Mesh shotgunMesh;
        public static Mesh riotShotgunMesh;
        public static Mesh slugShotgunMesh;
        public static Mesh machineGunMesh;
        public static Mesh heavyMachineGunMesh;
        public static Mesh bazookaMesh;
        public static Mesh rocketLauncherMesh;
        public static Mesh sniperMesh;
        public static Mesh armCannonMesh;
        public static Mesh plasmaCannonMesh;
        public static Mesh behemothMesh;
        public static Mesh beetleShieldMesh;
        public static Mesh grenadeLauncherMesh;
        public static Mesh lunarPistolMesh;
        public static Mesh voidPistolMesh;
        public static Mesh needlerMesh;
        public static Mesh badassShotgunMesh;
        public static Mesh lunarRifleMesh;
        public static Mesh lunarHammerMesh;
        public static Mesh nemmandoGunMesh;
        public static Mesh nemmercGunMesh;
        public static Mesh golemGunMesh;

        public static Material pistolMat;
        public static Material goldenGunMat;
        public static Material pyriteGunMat;
        public static Material shotgunMat;
        public static Material riotShotgunMat;
        public static Material slugShotgunMat;
        public static Material machineGunMat;
        public static Material heavyMachineGunMat;
        public static Material rocketLauncherMat;
        public static Material rocketLauncherAltMat;
        public static Material bazookaMat;
        public static Material sniperMat;
        public static Material armCannonMat;
        public static Material plasmaCannonMat;
        public static Material grenadeLauncherMat;
        public static Material needlerMat;
        public static Material badassShotgunMat;
        public static Material nemmandoGunMat;
        public static Material nemmercGunMat;

        public static Material knifeMat;

        public static GameObject shotgunShell;
        public static GameObject shotgunSlug;

        public static GameObject weaponPickup;
        public static GameObject weaponPickupLegendary;
        public static GameObject weaponPickupUnique;
        public static GameObject weaponPickupOld;

        public static GameObject weaponPickupEffect;
        public static GameObject discardedWeaponEffect;

        internal static Texture pistolWeaponIcon;
        internal static Texture goldenGunWeaponIcon;
        internal static Texture pyriteGunWeaponIcon;
        internal static Texture shotgunWeaponIcon;
        internal static Texture riotShotgunWeaponIcon;
        internal static Texture slugShotgunWeaponIcon;
        internal static Texture machineGunWeaponIcon;
        internal static Texture heavyMachineGunWeaponIcon;
        internal static Texture bazookaWeaponIcon;
        internal static Texture rocketLauncherWeaponIcon;
        internal static Texture rocketLauncherAltWeaponIcon;
        internal static Texture sniperWeaponIcon;
        internal static Texture armCannonWeaponIcon;
        internal static Texture plasmaCannonWeaponIcon;
        internal static Texture beetleShieldWeaponIcon;
        internal static Texture grenadeLauncherWeaponIcon;
        internal static Texture lunarPistolWeaponIcon;
        internal static Texture voidPistolWeaponIcon;
        internal static Texture needlerWeaponIcon;
        internal static Texture badassShotgunWeaponIcon;
        internal static Texture lunarRifleWeaponIcon;
        internal static Texture lunarHammerWeaponIcon;
        internal static Texture nemmandoGunWeaponIcon;
        internal static Texture nemmercGunWeaponIcon;
        internal static Texture golemGunWeaponIcon;

        public static GameObject shotgunTracer;
        public static GameObject shotgunTracerCrit;

        public static GameObject lunarTracer;
        public static GameObject lunarRifleTracer;

        public static GameObject nemmandoTracer;

        public static GameObject nemmercTracer;

        public static GameObject lunarShardMuzzleFlash;

        internal static DriverWeaponDef pistolWeaponDef;
        internal static DriverWeaponDef goldenGunWeaponDef;
        internal static DriverWeaponDef pyriteGunWeaponDef;
        internal static DriverWeaponDef shotgunWeaponDef;
        internal static DriverWeaponDef riotShotgunWeaponDef;
        internal static DriverWeaponDef slugShotgunWeaponDef;
        internal static DriverWeaponDef machineGunWeaponDef;
        internal static DriverWeaponDef heavyMachineGunWeaponDef;
        internal static DriverWeaponDef bazookaWeaponDef;
        internal static DriverWeaponDef rocketLauncherWeaponDef;
        internal static DriverWeaponDef rocketLauncherAltWeaponDef;
        internal static DriverWeaponDef sniperWeaponDef;
        internal static DriverWeaponDef armCannonWeaponDef;
        internal static DriverWeaponDef plasmaCannonWeaponDef;
        internal static DriverWeaponDef beetleShieldWeaponDef;
        internal static DriverWeaponDef behemothWeaponDef;
        internal static DriverWeaponDef grenadeLauncherWeaponDef;
        internal static DriverWeaponDef lunarPistolWeaponDef;
        internal static DriverWeaponDef voidPistolWeaponDef;
        internal static DriverWeaponDef needlerWeaponDef;
        internal static DriverWeaponDef badassShotgunWeaponDef;
        internal static DriverWeaponDef lunarRifleWeaponDef;
        internal static DriverWeaponDef lunarHammerWeaponDef;
        internal static DriverWeaponDef nemmandoGunWeaponDef;
        internal static DriverWeaponDef nemmercGunWeaponDef;
        internal static DriverWeaponDef golemGunWeaponDef;

        internal static void PopulateAssets()
        {
            if (mainAssetBundle == null)
            {
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DriverMod.robdriver"))
                {
                    mainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }
            }

            using (Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("DriverMod.driver_bank.bnk"))
            {
                byte[] array = new byte[manifestResourceStream2.Length];
                manifestResourceStream2.Read(array, 0, array.Length);
                SoundAPI.SoundBanks.Add(array);
            }

            jammedEffectPrefab = CreateTextPopupEffect("DriverGunJammedEffect", "ROB_DRIVER_JAMMED_POPUP");

            upgradeEffectPrefab = CreateTextPopupEffect("DriverGunUpgradeEffect", "ROB_DRIVER_UPGRADE_POPUP");

            hammerImpactSoundDef = CreateNetworkSoundEventDef("sfx_driver_impact_hammer");

            #region Pistol Aim Mode Crosshair
            pistolAimCrosshairPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/UI/StandardCrosshair.prefab").WaitForCompletion().InstantiateClone("DriverPistolAimCrosshair", false);

            GameObject stockHolder = GameObject.Instantiate(Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Mage/MageCrosshair.prefab").WaitForCompletion().transform.Find("Stock").gameObject);
            stockHolder.transform.parent = pistolAimCrosshairPrefab.transform;

            CrosshairController pistolCrosshair = pistolAimCrosshairPrefab.GetComponent<CrosshairController>();

            pistolCrosshair.skillStockSpriteDisplays = new CrosshairController.SkillStockSpriteDisplay[]
            {
                new CrosshairController.SkillStockSpriteDisplay
                {
                    target = stockHolder.transform.GetChild(0).gameObject,
                    skillSlot = SkillSlot.Secondary,
                    minimumStockCountToBeValid = 1,
                    maximumStockCountToBeValid = 99
                },
                new CrosshairController.SkillStockSpriteDisplay
                {
                    target = stockHolder.transform.GetChild(1).gameObject,
                    skillSlot = SkillSlot.Secondary,
                    minimumStockCountToBeValid = 2,
                    maximumStockCountToBeValid = 99
                },
                new CrosshairController.SkillStockSpriteDisplay
                {
                    target = stockHolder.transform.GetChild(2).gameObject,
                    skillSlot = SkillSlot.Secondary,
                    minimumStockCountToBeValid = 3,
                    maximumStockCountToBeValid = 99
                },
                new CrosshairController.SkillStockSpriteDisplay
                {
                    target = stockHolder.transform.GetChild(3).gameObject,
                    skillSlot = SkillSlot.Secondary,
                    minimumStockCountToBeValid = 4,
                    maximumStockCountToBeValid = 99
                }
            };

            GameObject chargeBar = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("ChargeBar"));
            chargeBar.transform.SetParent(pistolAimCrosshairPrefab.transform);

            RectTransform rect = chargeBar.GetComponent<RectTransform>();

            rect.localScale = new Vector3(0.75f, 0.075f, 1f);
            rect.anchorMin = new Vector2(0f, 0f);
            rect.anchorMax = new Vector2(0f, 0f);
            rect.pivot = new Vector2(0.5f, 0f);
            rect.anchoredPosition = new Vector2(50f, 0f);
            rect.localPosition = new Vector3(0f, -60f, 0f);

            chargeBar.transform.GetChild(0).gameObject.AddComponent<Modules.Components.CrosshairChargeBar>().crosshairController = pistolAimCrosshairPrefab.GetComponent<RoR2.UI.CrosshairController>();
            #endregion

            #region Bazooka Crosshair
            bazookaCrosshairPrefab = PrefabAPI.InstantiateClone(LoadCrosshair("ToolbotGrenadeLauncher"), "DriverBazookaCrosshair", false);
            CrosshairController crosshair = bazookaCrosshairPrefab.GetComponent<CrosshairController>();
            crosshair.skillStockSpriteDisplays = new CrosshairController.SkillStockSpriteDisplay[0];

            bazookaCrosshairPrefab.transform.GetChild(0).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = bazookaCrosshairPrefab.transform.GetChild(0).GetComponent<RectTransform>();
            rect.localEulerAngles = Vector3.zero;
            rect.anchoredPosition = new Vector2(-50f, -10f);

            bazookaCrosshairPrefab.transform.GetChild(1).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = bazookaCrosshairPrefab.transform.GetChild(1).GetComponent<RectTransform>();
            rect.localEulerAngles = new Vector3(0f, 0f, 90f);

            bazookaCrosshairPrefab.transform.GetChild(2).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = bazookaCrosshairPrefab.transform.GetChild(2).GetComponent<RectTransform>();
            rect.localEulerAngles = Vector3.zero;
            rect.anchoredPosition = new Vector2(50f, -10f);

            bazookaCrosshairPrefab.transform.Find("StockCountHolder").gameObject.SetActive(false);
            bazookaCrosshairPrefab.transform.Find("Image, Arrow (1)").gameObject.SetActive(true);

            crosshair.spriteSpreadPositions[0].zeroPosition = new Vector3(0f, 25f, 0f);
            crosshair.spriteSpreadPositions[0].onePosition = new Vector3(-50f, 25f, 0f);

            crosshair.spriteSpreadPositions[1].zeroPosition = new Vector3(100f, 0f, 0f);
            crosshair.spriteSpreadPositions[1].onePosition = new Vector3(150f, 0f, 0f);

            crosshair.spriteSpreadPositions[2].zeroPosition = new Vector3(0f, 25f, 0f);
            crosshair.spriteSpreadPositions[2].onePosition = new Vector3(50f, 25f, 0f);

            chargeBar = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("ChargeBar"));
            chargeBar.transform.SetParent(bazookaCrosshairPrefab.transform);

            rect = chargeBar.GetComponent<RectTransform>();

            rect.localScale = new Vector3(0.5f, 0.1f, 1f);
            rect.anchorMin = new Vector2(0f, 0f);
            rect.anchorMax = new Vector2(0f, 0f);
            rect.pivot = new Vector2(0.5f, 0f);
            rect.anchoredPosition = new Vector2(50f, 0f);
            rect.localPosition = new Vector3(40f, -40f, 0f);
            rect.localEulerAngles = new Vector3(0f, 0f, 90f);

            chargeBar.transform.GetChild(0).gameObject.AddComponent<Modules.Components.CrosshairChargeBar>().crosshairController = crosshair;
            #endregion

            #region Grenade Launcher Crosshair
            grenadeLauncherCrosshairPrefab = PrefabAPI.InstantiateClone(LoadCrosshair("ToolbotGrenadeLauncher"), "DriverGrenadeLauncherCrosshair", false);
            crosshair = grenadeLauncherCrosshairPrefab.GetComponent<CrosshairController>();
            crosshair.skillStockSpriteDisplays = new CrosshairController.SkillStockSpriteDisplay[0];

            grenadeLauncherCrosshairPrefab.transform.GetChild(0).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = grenadeLauncherCrosshairPrefab.transform.GetChild(0).GetComponent<RectTransform>();
            rect.localEulerAngles = Vector3.zero;
            rect.anchoredPosition = new Vector2(-50f, -10f);

            grenadeLauncherCrosshairPrefab.transform.GetChild(1).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = grenadeLauncherCrosshairPrefab.transform.GetChild(1).GetComponent<RectTransform>();
            rect.localEulerAngles = new Vector3(0f, 0f, 90f);

            grenadeLauncherCrosshairPrefab.transform.GetChild(2).GetComponentInChildren<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperNib.png").WaitForCompletion();
            rect = grenadeLauncherCrosshairPrefab.transform.GetChild(2).GetComponent<RectTransform>();
            rect.localEulerAngles = Vector3.zero;
            rect.anchoredPosition = new Vector2(50f, -10f);

            grenadeLauncherCrosshairPrefab.transform.Find("StockCountHolder").gameObject.SetActive(false);
            grenadeLauncherCrosshairPrefab.transform.Find("Image, Arrow (1)").gameObject.SetActive(true);

            crosshair.spriteSpreadPositions[0].zeroPosition = new Vector3(25f, 25f, 0f);
            crosshair.spriteSpreadPositions[0].onePosition = new Vector3(-25f, 25f, 0f);

            crosshair.spriteSpreadPositions[1].zeroPosition = new Vector3(75f, 0f, 0f);
            crosshair.spriteSpreadPositions[1].onePosition = new Vector3(125f, 0f, 0f);

            crosshair.spriteSpreadPositions[2].zeroPosition = new Vector3(-25f, 25f, 0f);
            crosshair.spriteSpreadPositions[2].onePosition = new Vector3(25f, 25f, 0f);
            #endregion

            #region Rocket Launcher Crosshair
            rocketLauncherCrosshairPrefab = PrefabAPI.InstantiateClone(LoadCrosshair("ToolbotGrenadeLauncher"), "DriveRocketLauncherCrosshair", false);
            crosshair = rocketLauncherCrosshairPrefab.GetComponent<CrosshairController>();
            crosshair.skillStockSpriteDisplays = new CrosshairController.SkillStockSpriteDisplay[0];
            rocketLauncherCrosshairPrefab.transform.Find("StockCountHolder").gameObject.SetActive(false);
            #endregion

            #region Needler Crosshair
            needlerCrosshairPrefab = PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Crosshair/LoaderCrosshair"), "DriverNeedlerCrosshair", false);
            DriverPlugin.Destroy(needlerCrosshairPrefab.GetComponent<LoaderHookCrosshairController>());

            needlerCrosshairPrefab.GetComponent<RawImage>().enabled = false;

            var control = needlerCrosshairPrefab.GetComponent<CrosshairController>();

            control.maxSpreadAlpha = 0;
            control.maxSpreadAngle = 3;
            control.minSpreadAlpha = 0;
            control.spriteSpreadPositions = new CrosshairController.SpritePosition[]
            {
                new CrosshairController.SpritePosition
                {
                    target = needlerCrosshairPrefab.transform.GetChild(2).GetComponent<RectTransform>(),
                    zeroPosition = new Vector3(-20f, 0, 0),
                    onePosition = new Vector3(-48f, 0, 0)
                },
                new CrosshairController.SpritePosition
                {
                    target = needlerCrosshairPrefab.transform.GetChild(3).GetComponent<RectTransform>(),
                    zeroPosition = new Vector3(20f, 0, 0),
                    onePosition = new Vector3(48f, 0, 0)
                }
            };

            DriverPlugin.Destroy(needlerCrosshairPrefab.transform.GetChild(0).gameObject);
            DriverPlugin.Destroy(needlerCrosshairPrefab.transform.GetChild(1).gameObject);
            #endregion

            circleCrosshairPrefab = CreateCrosshair();

            pistolMesh = mainAssetBundle.LoadAsset<Mesh>("meshPistol");
            goldenGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshGoldenGun");
            shotgunMesh = mainAssetBundle.LoadAsset<Mesh>("meshSuperShotgun");
            riotShotgunMesh = mainAssetBundle.LoadAsset<Mesh>("meshRiotShotgun");
            slugShotgunMesh = mainAssetBundle.LoadAsset<Mesh>("meshSlugShotgun");
            machineGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshMachineGun");
            heavyMachineGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshHeavyMachineGun");
            bazookaMesh = mainAssetBundle.LoadAsset<Mesh>("meshBazooka");
            rocketLauncherMesh = mainAssetBundle.LoadAsset<Mesh>("meshRocketLauncher");
            sniperMesh = mainAssetBundle.LoadAsset<Mesh>("meshSniperRifle");
            armCannonMesh = mainAssetBundle.LoadAsset<Mesh>("meshArmCannon");
            plasmaCannonMesh = mainAssetBundle.LoadAsset<Mesh>("meshPlasmaCannon");
            behemothMesh = mainAssetBundle.LoadAsset<Mesh>("meshBehemoth");
            beetleShieldMesh = mainAssetBundle.LoadAsset<Mesh>("meshBeetleShield");
            grenadeLauncherMesh = mainAssetBundle.LoadAsset<Mesh>("meshGrenadeLauncher");
            lunarPistolMesh = mainAssetBundle.LoadAsset<Mesh>("meshLunarPistol");
            voidPistolMesh = mainAssetBundle.LoadAsset<Mesh>("meshVoidPistol");
            needlerMesh = mainAssetBundle.LoadAsset<Mesh>("meshNeedler");
            badassShotgunMesh = mainAssetBundle.LoadAsset<Mesh>("meshSixBarrelShotgun");
            lunarRifleMesh = mainAssetBundle.LoadAsset<Mesh>("meshLunarRifle");
            lunarHammerMesh = mainAssetBundle.LoadAsset<Mesh>("meshLunarHammer");
            nemmandoGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshNemmandoGun");
            nemmercGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshNemmercGun");
            golemGunMesh = mainAssetBundle.LoadAsset<Mesh>("meshGolemGun");

            pistolMat = CreateMaterial("matPistol");
            goldenGunMat = CreateMaterial("matGoldenGun");
            pyriteGunMat = CreateMaterial("matPyriteGun");
            shotgunMat = CreateMaterial("matShotgun");
            riotShotgunMat = CreateMaterial("matRiotShotgun");
            slugShotgunMat = CreateMaterial("matSlugShotgun");
            machineGunMat = CreateMaterial("matMachineGun");
            heavyMachineGunMat = CreateMaterial("matHeavyMachineGun");
            bazookaMat = CreateMaterial("matBazooka");
            rocketLauncherMat = CreateMaterial("matRocketLauncher");
            rocketLauncherAltMat = CreateMaterial("matRocketLauncherAlt");
            sniperMat = CreateMaterial("matSniperRifle");
            armCannonMat = CreateMaterial("matArmCannon", 1f);
            plasmaCannonMat = CreateMaterial("matPlasmaCannon", 30f, Color.white);
            grenadeLauncherMat = CreateMaterial("matGrenadeLauncher");
            needlerMat = CreateMaterial("matNeedler", 5f, Color.white);
            badassShotgunMat = CreateMaterial("matSawedOff");
            nemmandoGunMat = CreateMaterial("matNemmandoGun", 5f, Color.white, 1f);
            nemmercGunMat = CreateMaterial("matNemmercGun", 5f, Color.white, 1f);

            knifeMat = CreateMaterial("matKnife");

            shotgunShell = mainAssetBundle.LoadAsset<GameObject>("ShotgunShell");
            shotgunShell.GetComponentInChildren<MeshRenderer>().material = CreateMaterial("matShotgunShell");
            shotgunShell.AddComponent<Modules.Components.ShellController>();

            shotgunSlug = mainAssetBundle.LoadAsset<GameObject>("ShotgunSlug");
            shotgunSlug.GetComponentInChildren<MeshRenderer>().material = CreateMaterial("matShotgunSlug");
            shotgunSlug.AddComponent<Modules.Components.ShellController>();


            #region Normal weapon pickup
            weaponPickup = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandolier/AmmoPack.prefab").WaitForCompletion().InstantiateClone("DriverWeaponPickup", true);

            weaponPickup.GetComponent<BeginRapidlyActivatingAndDeactivating>().delayBeforeBeginningBlinking = 55f;
            weaponPickup.GetComponent<DestroyOnTimer>().duration = 60f;

            AmmoPickup ammoPickupComponent = weaponPickup.GetComponentInChildren<AmmoPickup>();
            Components.WeaponPickup weaponPickupComponent = ammoPickupComponent.gameObject.AddComponent<Components.WeaponPickup>();

            weaponPickupComponent.baseObject = ammoPickupComponent.baseObject;
            weaponPickupComponent.pickupEffect = ammoPickupComponent.pickupEffect;
            weaponPickupComponent.teamFilter = ammoPickupComponent.teamFilter;

            Material uncommonPickupMat = Material.Instantiate(Addressables.LoadAssetAsync<Material>("RoR2/Base/Bandolier/matPickups.mat").WaitForCompletion());
            uncommonPickupMat.SetColor("_TintColor", new Color(0f, 80f / 255f, 0f, 1f));

            weaponPickup.GetComponentInChildren<MeshRenderer>().enabled = false;/*.materials = new Material[]
            {
                Assets.shotgunMat,
                uncommonPickupMat
            };*/

            GameObject pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickup"));
            pickupModel.transform.parent = weaponPickup.transform.Find("Visuals");
            pickupModel.transform.localPosition = new Vector3(0f, -0.35f, 0f);
            pickupModel.transform.localRotation = Quaternion.identity;

            MeshRenderer pickupMesh = pickupModel.GetComponentInChildren<MeshRenderer>();
            /*pickupMesh.materials = new Material[]
            {
                CreateMaterial("matCrate1"),
                CreateMaterial("matCrate2")//,
                //uncommonPickupMat
            };*/
            pickupMesh.material = CreateMaterial("matBriefcase");

            GameObject textShit = GameObject.Instantiate(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc"));
            MonoBehaviour.Destroy(textShit.GetComponent<EffectComponent>());
            textShit.transform.parent = pickupModel.transform;
            textShit.transform.localPosition = Vector3.zero;
            textShit.transform.localRotation = Quaternion.identity;

            textShit.GetComponent<DestroyOnTimer>().enabled = false;

            ObjectScaleCurve whatTheFuckIsThis = textShit.GetComponentInChildren<ObjectScaleCurve>();
            //whatTheFuckIsThis.enabled = false;
            //whatTheFuckIsThis.transform.localScale = Vector3.one * 2;
            //whatTheFuckIsThis.timeMax = 60f;
            Transform helpMe = whatTheFuckIsThis.transform;
            MonoBehaviour.DestroyImmediate(whatTheFuckIsThis);
            helpMe.transform.localScale = Vector3.one * 1.25f;

            MonoBehaviour.Destroy(ammoPickupComponent);
            MonoBehaviour.Destroy(weaponPickup.GetComponentInChildren<RoR2.GravitatePickup>());
            #endregion

            #region Legendary weapon pickup
            weaponPickupLegendary = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandolier/AmmoPack.prefab").WaitForCompletion().InstantiateClone("DriverWeaponPickupLegendary", true);

            weaponPickupLegendary.GetComponent<BeginRapidlyActivatingAndDeactivating>().delayBeforeBeginningBlinking = 110f;
            weaponPickupLegendary.GetComponent<DestroyOnTimer>().duration = 120f;

            AmmoPickup ammoPickupComponent2 = weaponPickupLegendary.GetComponentInChildren<AmmoPickup>();
            Components.WeaponPickup weaponPickupComponent2 = ammoPickupComponent2.gameObject.AddComponent<Components.WeaponPickup>();

            weaponPickupComponent2.baseObject = ammoPickupComponent2.baseObject;
            weaponPickupComponent2.pickupEffect = ammoPickupComponent2.pickupEffect;
            weaponPickupComponent2.teamFilter = ammoPickupComponent2.teamFilter;

            weaponPickupLegendary.GetComponentInChildren<MeshRenderer>().enabled = false;

            GameObject pickupModel2 = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupLegendary"));
            pickupModel2.transform.parent = weaponPickupLegendary.transform.Find("Visuals");
            pickupModel2.transform.localPosition = new Vector3(0f, -0.35f, 0f);
            pickupModel2.transform.localRotation = Quaternion.identity;

            MeshRenderer pickupMesh2 = pickupModel2.GetComponentInChildren<MeshRenderer>();
            pickupMesh2.material = CreateMaterial("matBriefcaseGold");

            GameObject textShit2 = GameObject.Instantiate(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc"));
            MonoBehaviour.Destroy(textShit2.GetComponent<EffectComponent>());
            textShit2.transform.parent = pickupModel2.transform;
            textShit2.transform.localPosition = Vector3.zero;
            textShit2.transform.localRotation = Quaternion.identity;

            textShit2.GetComponent<DestroyOnTimer>().enabled = false;

            ObjectScaleCurve whatTheFuckIsThis2 = textShit2.GetComponentInChildren<ObjectScaleCurve>();
            //whatTheFuckIsThis.enabled = false;
            //whatTheFuckIsThis.transform.localScale = Vector3.one * 2;
            //whatTheFuckIsThis.timeMax = 60f;
            Transform helpMe2 = whatTheFuckIsThis2.transform;
            MonoBehaviour.DestroyImmediate(whatTheFuckIsThis2);
            helpMe2.transform.localScale = Vector3.one * 1.25f;

            MonoBehaviour.Destroy(ammoPickupComponent2);
            MonoBehaviour.Destroy(weaponPickupLegendary.GetComponentInChildren<RoR2.GravitatePickup>());
            #endregion

            #region Unique weapon pickup
            weaponPickupUnique = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandolier/AmmoPack.prefab").WaitForCompletion().InstantiateClone("DriverweaponPickupUnique", true);

            weaponPickupUnique.GetComponent<BeginRapidlyActivatingAndDeactivating>().delayBeforeBeginningBlinking = 110f;
            weaponPickupUnique.GetComponent<DestroyOnTimer>().duration = 120f;

            AmmoPickup ammoPickupComponent3 = weaponPickupUnique.GetComponentInChildren<AmmoPickup>();
            Components.WeaponPickup weaponPickupComponent3 = ammoPickupComponent3.gameObject.AddComponent<Components.WeaponPickup>();

            weaponPickupComponent3.baseObject = ammoPickupComponent3.baseObject;
            weaponPickupComponent3.pickupEffect = ammoPickupComponent3.pickupEffect;
            weaponPickupComponent3.teamFilter = ammoPickupComponent3.teamFilter;

            weaponPickupUnique.GetComponentInChildren<MeshRenderer>().enabled = false;

            GameObject pickupModel3 = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupUnique"));
            pickupModel3.transform.parent = weaponPickupUnique.transform.Find("Visuals");
            pickupModel3.transform.localPosition = new Vector3(0f, -0.35f, 0f);
            pickupModel3.transform.localRotation = Quaternion.identity;

            MeshRenderer pickupMesh3 = pickupModel3.GetComponentInChildren<MeshRenderer>();
            pickupMesh3.material = CreateMaterial("matBriefcaseUnique");

            GameObject textShit3 = GameObject.Instantiate(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc"));
            MonoBehaviour.Destroy(textShit3.GetComponent<EffectComponent>());
            textShit3.transform.parent = pickupModel3.transform;
            textShit3.transform.localPosition = Vector3.zero;
            textShit3.transform.localRotation = Quaternion.identity;

            textShit3.GetComponent<DestroyOnTimer>().enabled = false;

            ObjectScaleCurve whatTheFuckIsThis3 = textShit3.GetComponentInChildren<ObjectScaleCurve>();
            Transform helpMe3 = whatTheFuckIsThis3.transform;
            MonoBehaviour.DestroyImmediate(whatTheFuckIsThis3);
            helpMe3.transform.localScale = Vector3.one * 1.25f;

            MonoBehaviour.Destroy(ammoPickupComponent3);
            MonoBehaviour.Destroy(weaponPickupUnique.GetComponentInChildren<RoR2.GravitatePickup>());
            #endregion

            #region Old weapon pickup
            weaponPickupOld = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandolier/AmmoPack.prefab").WaitForCompletion().InstantiateClone("DriverWeaponPickupOld", true);

            weaponPickupOld.GetComponent<BeginRapidlyActivatingAndDeactivating>().delayBeforeBeginningBlinking = 55f;
            weaponPickupOld.GetComponent<DestroyOnTimer>().duration = 60f;

            AmmoPickup ammoPickupComponent4 = weaponPickupOld.GetComponentInChildren<AmmoPickup>();
            Components.WeaponPickup weaponPickupComponent4 = ammoPickupComponent4.gameObject.AddComponent<Components.WeaponPickup>();

            weaponPickupComponent4.baseObject = ammoPickupComponent4.baseObject;
            weaponPickupComponent4.pickupEffect = ammoPickupComponent4.pickupEffect;
            weaponPickupComponent4.teamFilter = ammoPickupComponent4.teamFilter;

            weaponPickupOld.GetComponentInChildren<MeshRenderer>().enabled = false;

            GameObject pickupModel4 = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupOld"));
            pickupModel4.transform.parent = weaponPickupOld.transform.Find("Visuals");
            pickupModel4.transform.localPosition = new Vector4(0f, -0.35f, 0f);
            pickupModel4.transform.localRotation = Quaternion.identity;

            MeshRenderer pickupMesh4 = pickupModel4.GetComponentInChildren<MeshRenderer>();
            pickupMesh4.materials = new Material[]
            {
                CreateMaterial("matCrate1"),
                CreateMaterial("matCrate2")
            };

             GameObject textShit4 = GameObject.Instantiate(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc"));
            MonoBehaviour.Destroy(textShit4.GetComponent<EffectComponent>());
            textShit4.transform.parent = pickupModel4.transform;
            textShit4.transform.localPosition = Vector4.zero;
            textShit4.transform.localRotation = Quaternion.identity;

            textShit4.GetComponent<DestroyOnTimer>().enabled = false;

            ObjectScaleCurve whatTheFuckIsThis4 = textShit4.GetComponentInChildren<ObjectScaleCurve>();
            //whatTheFuckIsThis.enabled = false;
            //whatTheFuckIsThis.transform.localScale = Vector4.one * 2;
            //whatTheFuckIsThis.timeMax = 60f;
            Transform helpMe4 = whatTheFuckIsThis4.transform;
            MonoBehaviour.DestroyImmediate(whatTheFuckIsThis4);
            helpMe4.transform.localScale = Vector4.one * 1.25f;

            MonoBehaviour.Destroy(ammoPickupComponent4);
            MonoBehaviour.Destroy(weaponPickupOld.GetComponentInChildren<RoR2.GravitatePickup>());
            #endregion

            weaponPickupEffect = weaponPickupComponent.pickupEffect.InstantiateClone("RobDriverWeaponPickupEffect", true);
            weaponPickupEffect.AddComponent<NetworkIdentity>();
            AddNewEffectDef(weaponPickupEffect, "sfx_driver_pickup");


            weaponPickupComponent.pickupEffect = weaponPickupEffect;
            weaponPickupComponent2.pickupEffect = weaponPickupEffect;
            weaponPickupComponent3.pickupEffect = weaponPickupEffect;
            weaponPickupComponent4.pickupEffect = weaponPickupEffect;


            weaponNotificationPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/UI/NotificationPanel2.prefab").WaitForCompletion().InstantiateClone("WeaponNotification", false);
            WeaponNotification _new = weaponNotificationPrefab.AddComponent<WeaponNotification>();
            GenericNotification _old = weaponNotificationPrefab.GetComponent<GenericNotification>();

            _new.titleText = _old.titleText;
            _new.titleTMP = _old.titleTMP;
            _new.descriptionText = _old.descriptionText;
            _new.iconImage = _old.iconImage;
            _new.previousIconImage = _old.previousIconImage;
            _new.canvasGroup = _old.canvasGroup;
            _new.fadeOutT = _old.fadeOutT;

            _old.enabled = false;


            pistolWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texPistolWeaponIcon");
            goldenGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texGoldenGunWeaponIcon");
            pyriteGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texPyriteGunWeaponIcon");
            shotgunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texShotgunWeaponIcon");
            riotShotgunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texRiotShotgunWeaponIcon");
            slugShotgunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texSlugShotgunWeaponIcon");
            machineGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texMachineGunWeaponIcon");
            heavyMachineGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texHeavyMachineGunWeaponIcon");
            bazookaWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texBazookaWeaponIcon");
            rocketLauncherWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texRocketLauncherWeaponIcon");
            rocketLauncherAltWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texRocketLauncherAltWeaponIcon");
            sniperWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texSniperRifleWeaponIcon");
            armCannonWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texArmCannonWeaponIcon");
            plasmaCannonWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texPlasmaCannonWeaponIcon");
            beetleShieldWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texBeetleShieldWeaponIcon");
            grenadeLauncherWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texGrenadeLauncherWeaponIcon");
            lunarPistolWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texLunarPistolWeaponIcon");
            voidPistolWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texVoidPistolWeaponIcon");
            needlerWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texNeedlerWeaponIcon");
            badassShotgunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texBadassShotgunWeaponIcon");
            lunarRifleWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texLunarRifleWeaponIcon");
            lunarHammerWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texLunarHammerWeaponIcon");
            nemmandoGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texNemmandoWeaponIcon");
            nemmercGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texNemmercWeaponIcon");
            golemGunWeaponIcon = mainAssetBundle.LoadAsset<Texture>("texGolemGunWeaponIcon");


            shotgunTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("DriverShotgunTracer", true);

            if (!shotgunTracer.GetComponent<EffectComponent>()) shotgunTracer.AddComponent<EffectComponent>();
            if (!shotgunTracer.GetComponent<VFXAttributes>()) shotgunTracer.AddComponent<VFXAttributes>();
            if (!shotgunTracer.GetComponent<NetworkIdentity>()) shotgunTracer.AddComponent<NetworkIdentity>();

            Material bulletMat = null;

            foreach (LineRenderer i in shotgunTracer.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", new Color(0.68f, 0.58f, 0.05f));
                    i.material = bulletMat;
                    i.startColor = new Color(0.68f, 0.58f, 0.05f);
                    i.endColor = new Color(0.68f, 0.58f, 0.05f);
                }
            }

            shotgunTracerCrit = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("DriverShotgunTracerCritical", true);

            if (!shotgunTracerCrit.GetComponent<EffectComponent>()) shotgunTracerCrit.AddComponent<EffectComponent>();
            if (!shotgunTracerCrit.GetComponent<VFXAttributes>()) shotgunTracerCrit.AddComponent<VFXAttributes>();
            if (!shotgunTracerCrit.GetComponent<NetworkIdentity>()) shotgunTracerCrit.AddComponent<NetworkIdentity>();

            foreach (LineRenderer i in shotgunTracerCrit.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    Material material = UnityEngine.Object.Instantiate<Material>(i.material);
                    material.SetColor("_TintColor", Color.yellow);
                    i.material = material;
                    i.startColor = new Color(0.8f, 0.24f, 0f);
                    i.endColor = new Color(0.8f, 0.24f, 0f);
                }
            }

            lunarTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("DriverLunarPistolTracer", true);

            if (!lunarTracer.GetComponent<EffectComponent>()) lunarTracer.AddComponent<EffectComponent>();
            if (!lunarTracer.GetComponent<VFXAttributes>()) lunarTracer.AddComponent<VFXAttributes>();
            if (!lunarTracer.GetComponent<NetworkIdentity>()) lunarTracer.AddComponent<NetworkIdentity>();

            foreach (LineRenderer i in lunarTracer.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", new Color(0f, 102f / 255f, 1f));
                    i.material = bulletMat;
                    i.startColor = new Color(0f, 102f / 255f, 1f);
                    i.endColor = new Color(0f, 102f / 255f, 1f);
                }
            }

            lunarRifleTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerGolem").InstantiateClone("DriverLunarRifleTracer", true);

            if (!lunarRifleTracer.GetComponent<EffectComponent>()) lunarRifleTracer.AddComponent<EffectComponent>();
            if (!lunarRifleTracer.GetComponent<VFXAttributes>()) lunarRifleTracer.AddComponent<VFXAttributes>();
            if (!lunarRifleTracer.GetComponent<NetworkIdentity>()) lunarRifleTracer.AddComponent<NetworkIdentity>();

            lunarRifleTracer.transform.Find("SmokeBeam").GetComponent<ParticleSystemRenderer>().material = Addressables.LoadAssetAsync<Material>("RoR2/Base/LunarGolem/matLunarGolemChargeGlow.mat").WaitForCompletion();
            lunarRifleTracer.transform.Find("SmokeBeam").transform.localScale = new Vector3(1f, 0.25f, 0.25f);

            nemmandoTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("DriverNemmandoTracer", true);

            if (!nemmandoTracer.GetComponent<EffectComponent>()) nemmandoTracer.AddComponent<EffectComponent>();
            if (!nemmandoTracer.GetComponent<VFXAttributes>()) nemmandoTracer.AddComponent<VFXAttributes>();
            if (!nemmandoTracer.GetComponent<NetworkIdentity>()) nemmandoTracer.AddComponent<NetworkIdentity>();

            foreach (LineRenderer i in nemmandoTracer.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", Color.red);
                    i.material = bulletMat;
                    i.startColor = Color.red;
                    i.endColor = Color.red;
                }
            }

            nemmercTracer = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerCommandoShotgun").InstantiateClone("DriverNemmercTracer", true);

            if (!nemmercTracer.GetComponent<EffectComponent>()) nemmercTracer.AddComponent<EffectComponent>();
            if (!nemmercTracer.GetComponent<VFXAttributes>()) nemmercTracer.AddComponent<VFXAttributes>();
            if (!nemmercTracer.GetComponent<NetworkIdentity>()) nemmercTracer.AddComponent<NetworkIdentity>();

            foreach (LineRenderer i in lunarTracer.GetComponentsInChildren<LineRenderer>())
            {
                if (i)
                {
                    bulletMat = UnityEngine.Object.Instantiate<Material>(i.material);
                    bulletMat.SetColor("_TintColor", new Color(0f, 102f / 255f, 1f));
                    i.material = bulletMat;
                    i.startColor = new Color(0f, 102f / 255f, 1f);
                    i.endColor = new Color(0f, 102f / 255f, 1f);
                }
            }

            AddNewEffectDef(shotgunTracer);
            AddNewEffectDef(shotgunTracerCrit);
            AddNewEffectDef(lunarTracer);
            AddNewEffectDef(lunarRifleTracer);
            AddNewEffectDef(nemmandoTracer);
            AddNewEffectDef(nemmercTracer);

            Modules.Config.InitROO(Assets.mainAssetBundle.LoadAsset<Sprite>("texDriverIcon"), "Literally me");

            // actually i have to run this in driver's script, so the skilldefs can be created first
            //InitWeaponDefs();
            // kinda jank kinda not impactful enough to care about changing

            lunarShardMuzzleFlash = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Brother/MuzzleflashLunarShard.prefab").WaitForCompletion().InstantiateClone("DriverMuzzleflashLunarShard", false);
            lunarShardMuzzleFlash.transform.GetChild(0).transform.localScale = Vector3.one * 0.35f;
            lunarShardMuzzleFlash.transform.GetChild(1).transform.localScale = Vector3.one * 0.35f;
            lunarShardMuzzleFlash.transform.GetChild(2).transform.localScale = Vector3.one * 0.35f;

            AddNewEffectDef(lunarShardMuzzleFlash);


            discardedWeaponEffect = mainAssetBundle.LoadAsset<GameObject>("DiscardedWeapon");
            Modules.Components.DiscardedWeaponComponent discardComponent = discardedWeaponEffect.AddComponent<Modules.Components.DiscardedWeaponComponent>();
            discardedWeaponEffect.gameObject.layer = LayerIndex.ragdoll.intVal;
        }

        internal static GameObject CreatePickupObject(DriverWeaponDef weaponDef)
        {
            // nuclear solution...... i fucking hate modding
            GameObject newPickup = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandolier/AmmoPack.prefab").WaitForCompletion().InstantiateClone("DriverWeaponPickup" + weaponDef.index, true);

            AmmoPickup ammoPickupComponent = newPickup.GetComponentInChildren<AmmoPickup>();
            Components.WeaponPickup weaponPickupComponent = ammoPickupComponent.gameObject.AddComponent<Components.WeaponPickup>();

            weaponPickupComponent.baseObject = ammoPickupComponent.baseObject;
            weaponPickupComponent.pickupEffect = weaponPickupEffect;
            weaponPickupComponent.teamFilter = ammoPickupComponent.teamFilter;
            weaponPickupComponent.weaponDef = weaponDef;

            Material uncommonPickupMat = Material.Instantiate(Addressables.LoadAssetAsync<Material>("RoR2/Base/Bandolier/matPickups.mat").WaitForCompletion());
            uncommonPickupMat.SetColor("_TintColor", new Color(0f, 80f / 255f, 0f, 1f));

            newPickup.GetComponentInChildren<MeshRenderer>().enabled = false;

            GameObject pickupModel = null;
            float duration = 60f;
            
            switch (weaponDef.tier)
            {
                case DriverWeaponTier.Common:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickup"));
                    break;
                case DriverWeaponTier.Uncommon:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickup"));
                    break;
                case DriverWeaponTier.Legendary:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupLegendary"));
                    duration = 300f;
                    break;
                case DriverWeaponTier.Unique:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupUnique"));
                    duration = 300f;
                    break;
                case DriverWeaponTier.Lunar:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupLunar"));
                    duration = 300f;
                    break;
                case DriverWeaponTier.Void:
                    pickupModel = GameObject.Instantiate(mainAssetBundle.LoadAsset<GameObject>("WeaponPickupLegendary"));
                    duration = 300f;
                    break;
            }

            newPickup.GetComponent<BeginRapidlyActivatingAndDeactivating>().delayBeforeBeginningBlinking = duration - 5f;
            newPickup.GetComponent<DestroyOnTimer>().duration = duration;

            pickupModel.transform.parent = newPickup.transform.Find("Visuals");
            pickupModel.transform.localPosition = new Vector3(0f, -0.35f, 0f);
            pickupModel.transform.localRotation = Quaternion.identity;

            MeshRenderer pickupMesh = pickupModel.GetComponentInChildren<MeshRenderer>();

            switch (weaponDef.tier)
            {
                case DriverWeaponTier.Common:
                    pickupMesh.material = CreateMaterial("matBriefcase");
                    break;
                case DriverWeaponTier.Uncommon:
                    pickupMesh.material = CreateMaterial("matBriefcase");
                    break;
                case DriverWeaponTier.Legendary:
                    pickupMesh.material = CreateMaterial("matBriefcaseGold");
                    break;
                case DriverWeaponTier.Unique:
                    pickupMesh.material = CreateMaterial("matBriefcaseUnique");
                    break;
                case DriverWeaponTier.Lunar:
                    pickupMesh.material = CreateMaterial("matBriefcaseLunar");
                    break;
                case DriverWeaponTier.Void:
                    pickupMesh.material = CreateMaterial("matBriefcase");
                    break;
            }

            GameObject textShit = GameObject.Instantiate(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc"));
            MonoBehaviour.Destroy(textShit.GetComponent<EffectComponent>());
            textShit.transform.parent = pickupModel.transform;
            textShit.transform.localPosition = Vector3.zero;
            textShit.transform.localRotation = Quaternion.identity;

            textShit.GetComponent<DestroyOnTimer>().enabled = false;

            ObjectScaleCurve whatTheFuckIsThis = textShit.GetComponentInChildren<ObjectScaleCurve>();
            Transform helpMe = whatTheFuckIsThis.transform;
            MonoBehaviour.DestroyImmediate(whatTheFuckIsThis);
            helpMe.transform.localScale = Vector3.one * 1.25f;

            MonoBehaviour.Destroy(ammoPickupComponent);
            MonoBehaviour.Destroy(newPickup.GetComponentInChildren<RoR2.GravitatePickup>());

            newPickup.transform.Find("Visuals").Find("Particle System").Find("Particle System").gameObject.SetActive(false);
            newPickup.GetComponentInChildren<Light>().color = Modules.Survivors.Driver.characterColor;

            // i seriously hate this but it works
            return newPickup;
        }

        internal static void InitWeaponDefs()
        {
            // ignore this one, this is the default
            pistolWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_PISTOL_NAME",
                descriptionToken = "ROB_DRIVER_PISTOL_DESC",
                icon = Assets.pistolWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Common,
                primarySkillDef = null,
                secondarySkillDef = null,
                mesh = Assets.pistolMesh,
                material = Assets.pistolMat,
                animationSet = DriverWeaponDef.AnimationSet.Default
            });
            DriverWeaponCatalog.AddWeapon(pistolWeaponDef);
            DriverWeaponCatalog.Pistol = pistolWeaponDef;

            lunarPistolWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_LUNAR_PISTOL_NAME",
                descriptionToken = "ROB_DRIVER_LUNAR_PISTOL_DESC",
                icon = Assets.lunarPistolWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Lunar,
                primarySkillDef = Survivors.Driver.lunarPistolPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.lunarPistolSecondarySkillDef,
                mesh = Assets.lunarPistolMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/LunarGolem/matLunarGolem.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.Default
            });
            DriverWeaponCatalog.AddWeapon(lunarPistolWeaponDef);
            DriverWeaponCatalog.LunarPistol = lunarPistolWeaponDef;

            voidPistolWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_VOID_PISTOL_NAME",
                descriptionToken = "ROB_DRIVER_VOID_PISTOL_DESC",
                icon = Assets.voidPistolWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Lunar,
                primarySkillDef = Survivors.Driver.voidPistolPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.voidPistolSecondarySkillDef,
                mesh = Assets.voidPistolMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/DLC1/VoidJailer/matVoidJailer.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.Default
            });
            DriverWeaponCatalog.AddWeapon(voidPistolWeaponDef);
            DriverWeaponCatalog.VoidPistol = voidPistolWeaponDef;

            needlerWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_NEEDLER_NAME",
                descriptionToken = "ROB_DRIVER_NEEDLER_DESC",
                icon = Assets.needlerWeaponIcon,
                crosshairPrefab = Assets.needlerCrosshairPrefab,
                tier = DriverWeaponTier.Lunar,
                primarySkillDef = null,
                secondarySkillDef = null,
                mesh = Assets.needlerMesh,
                material = Assets.needlerMat,
                animationSet = DriverWeaponDef.AnimationSet.Default
            });
            DriverWeaponCatalog.AddWeapon(needlerWeaponDef);
            DriverWeaponCatalog.Needler = needlerWeaponDef;

            goldenGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_GOLDENGUN_NAME",
                descriptionToken = "ROB_DRIVER_GOLDENGUN_DESC",
                icon = Assets.goldenGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Unique,
                shotCount = 6,
                primarySkillDef = Survivors.Driver.goldenGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.goldenGunSecondarySkillDef,
                mesh = Assets.goldenGunMesh,
                material = Assets.goldenGunMat,
                animationSet = DriverWeaponDef.AnimationSet.Default,
                calloutSoundString = "sfx_driver_callout_generic",
                configIdentifier = "Golden Gun"
            });
            DriverWeaponCatalog.AddWeapon(goldenGunWeaponDef);
            DriverWeaponCatalog.GoldenGun = goldenGunWeaponDef;

            pyriteGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_PYRITEGUN_NAME",
                descriptionToken = "ROB_DRIVER_PYRITEGUN_DESC",
                icon = Assets.pyriteGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Unique,
                primarySkillDef = Survivors.Driver.pyriteGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.pyriteGunSecondarySkillDef,
                mesh = Assets.goldenGunMesh,
                material = Assets.pyriteGunMat,
                animationSet = DriverWeaponDef.AnimationSet.Default
            });
            DriverWeaponCatalog.AddWeapon(pyriteGunWeaponDef);
            DriverWeaponCatalog.PyriteGun = pyriteGunWeaponDef;

            beetleShieldWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_BEETLESHIELD_NAME",
                descriptionToken = "ROB_DRIVER_BEETLESHIELD_DESC",
                icon = Assets.beetleShieldWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Unique,
                shotCount = 32,
                primarySkillDef = Survivors.Driver.beetleShieldPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.beetleShieldSecondarySkillDef,
                mesh = Assets.beetleShieldMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Beetle/matBeetle.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.Default,
                calloutSoundString = "sfx_driver_callout_generic",
                configIdentifier = "Chitin Shield"
            });
            DriverWeaponCatalog.AddWeapon(beetleShieldWeaponDef);
            DriverWeaponCatalog.BeetleShield = beetleShieldWeaponDef;

            // example of creating a WeaponDef through code and adding it to the catalog for driver to obtain
            shotgunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_SHOTGUN_NAME",
                descriptionToken = "ROB_DRIVER_SHOTGUN_DESC",
                icon = Assets.shotgunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("SMG"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 8,
                primarySkillDef = Survivors.Driver.shotgunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.shotgunSecondarySkillDef,
                mesh = Assets.shotgunMesh,
                material = Assets.shotgunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_shotgun",
                configIdentifier = "Shotgun"
            });// now add it to the catalog here; catalog is necessary for networking
            DriverWeaponCatalog.AddWeapon(shotgunWeaponDef);

            riotShotgunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_RIOT_SHOTGUN_NAME",
                descriptionToken = "ROB_DRIVER_RIOT_SHOTGUN_DESC",
                icon = Assets.riotShotgunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("SMG"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 8,
                primarySkillDef = Survivors.Driver.riotShotgunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.riotShotgunSecondarySkillDef,
                mesh = Assets.riotShotgunMesh,
                material = Assets.riotShotgunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_shotgun",
                configIdentifier = "Riot Shotgun"
            });
            DriverWeaponCatalog.AddWeapon(riotShotgunWeaponDef);

            slugShotgunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_SLUG_SHOTGUN_NAME",
                descriptionToken = "ROB_DRIVER_SLUG_SHOTGUN_DESC",
                icon = Assets.slugShotgunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("SMG"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 8,
                primarySkillDef = Survivors.Driver.slugShotgunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.slugShotgunSecondarySkillDef,
                mesh = Assets.slugShotgunMesh,
                material = Assets.slugShotgunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_shotgun",
                configIdentifier = "Slug Shotgun"
            });
            DriverWeaponCatalog.AddWeapon(slugShotgunWeaponDef);

            machineGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_MACHINEGUN_NAME",
                descriptionToken = "ROB_DRIVER_MACHINEGUN_DESC",
                icon = Assets.machineGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 48,
                primarySkillDef = Survivors.Driver.machineGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.machineGunSecondarySkillDef,
                mesh = Assets.machineGunMesh,
                material = Assets.machineGunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_machine_gun",
                configIdentifier = "Machine Gun"
            });
            DriverWeaponCatalog.AddWeapon(machineGunWeaponDef);

            heavyMachineGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_HEAVY_MACHINEGUN_NAME",
                descriptionToken = "ROB_DRIVER_HEAVY_MACHINEGUN_DESC",
                icon = Assets.heavyMachineGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 44,
                primarySkillDef = Survivors.Driver.heavyMachineGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.heavyMachineGunSecondarySkillDef,
                mesh = Assets.heavyMachineGunMesh,
                material = Assets.heavyMachineGunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_hmg",
                configIdentifier = "Heavy Machine Gun"
            });
            DriverWeaponCatalog.AddWeapon(heavyMachineGunWeaponDef);

            sniperWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_SNIPER_NAME",
                descriptionToken = "ROB_DRIVER_SNIPER_DESC",
                icon = Assets.sniperWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Uncommon,
                shotCount = 6,
                primarySkillDef = Survivors.Driver.sniperPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.sniperSecondarySkillDef,
                mesh = Assets.sniperMesh,
                material = Assets.sniperMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_sniper",
                configIdentifier = "Sniper Rifle"
            });
            DriverWeaponCatalog.AddWeapon(sniperWeaponDef);

            bazookaWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_BAZOOKA_NAME",
                descriptionToken = "ROB_DRIVER_BAZOOKA_DESC",
                icon = Assets.bazookaWeaponIcon,
                crosshairPrefab = bazookaCrosshairPrefab,
                tier = DriverWeaponTier.Uncommon,
                shotCount = 8,
                primarySkillDef = Survivors.Driver.bazookaPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.bazookaSecondarySkillDef,
                mesh = Assets.bazookaMesh,
                material = Assets.bazookaMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_rocket_launcher",
                configIdentifier = "Bazooka"
            });
            DriverWeaponCatalog.AddWeapon(bazookaWeaponDef);

            grenadeLauncherWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_GRENADELAUNCHER_NAME",
                descriptionToken = "ROB_DRIVER_GRENADELAUNCHER_DESC",
                icon = Assets.grenadeLauncherWeaponIcon,
                crosshairPrefab = grenadeLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Uncommon,
                shotCount = 16,
                primarySkillDef = Survivors.Driver.grenadeLauncherPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.grenadeLauncherSecondarySkillDef,
                mesh = Assets.grenadeLauncherMesh,
                material = Assets.grenadeLauncherMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_grenade_launcher",
                configIdentifier = "Grenade Launcher"
            });
            DriverWeaponCatalog.AddWeapon(grenadeLauncherWeaponDef);

            rocketLauncherWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_ROCKETLAUNCHER_NAME",
                descriptionToken = "ROB_DRIVER_ROCKETLAUNCHER_DESC",
                icon = Assets.rocketLauncherWeaponIcon,
                crosshairPrefab = rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Legendary,
                shotCount = 20,
                primarySkillDef = Survivors.Driver.rocketLauncherPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.rocketLauncherSecondarySkillDef,
                mesh = Assets.rocketLauncherMesh,
                material = Assets.rocketLauncherMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_rocket_launcher",
                configIdentifier = "Rocket Launcher"
            });
            DriverWeaponCatalog.AddWeapon(rocketLauncherWeaponDef);

            behemothWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_BEHEMOTH_NAME",
                descriptionToken = "ROB_DRIVER_BEHEMOTH_DESC",
                icon = Addressables.LoadAssetAsync<Texture>("RoR2/Base/Behemoth/texBehemothIcon.png").WaitForCompletion(),
                crosshairPrefab = rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Unique,
                shotCount = 20,
                primarySkillDef = Survivors.Driver.behemothPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.behemothSecondarySkillDef,
                mesh = Assets.behemothMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Behemoth/matBehemoth.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_rocket_launcher",
                configIdentifier = "Brilliant Behemoth"
            });
            DriverWeaponCatalog.AddWeapon(behemothWeaponDef);
            DriverWeaponCatalog.Behemoth = behemothWeaponDef;

            rocketLauncherAltWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_ROCKETLAUNCHER_ALT_NAME",
                descriptionToken = "ROB_DRIVER_ROCKETLAUNCHER_ALT_DESC",
                icon = Assets.rocketLauncherAltWeaponIcon,
                crosshairPrefab = rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Unique,
                shotCount = 10,
                primarySkillDef = Survivors.Driver.rocketLauncherAltPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.rocketLauncherAltSecondarySkillDef,
                mesh = Assets.rocketLauncherMesh,
                material = Assets.rocketLauncherAltMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_rocket_launcher",
                configIdentifier = "Prototype Rocket Launcher"
            });
            DriverWeaponCatalog.AddWeapon(rocketLauncherAltWeaponDef);
            DriverWeaponCatalog.PrototypeRocketLauncher = rocketLauncherAltWeaponDef;

            armCannonWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_ARMCANNON_NAME",
                descriptionToken = "ROB_DRIVER_ARMCANNON_DESC",
                icon = Assets.armCannonWeaponIcon,
                crosshairPrefab = rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Unique,
                shotCount = 15,
                primarySkillDef = Survivors.Driver.armCannonPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.armCannonSecondarySkillDef,
                mesh = Assets.armCannonMesh,
                material = Assets.armCannonMat,
                animationSet = DriverWeaponDef.AnimationSet.Default,
                calloutSoundString = "sfx_driver_callout_generic",
                configIdentifier = "Arm Cannon"
            });
            DriverWeaponCatalog.AddWeapon(armCannonWeaponDef);
            DriverWeaponCatalog.ArmCannon = armCannonWeaponDef;

            plasmaCannonWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_PLASMACANNON_NAME",
                descriptionToken = "ROB_DRIVER_PLASMACANNON_DESC",
                icon = Assets.plasmaCannonWeaponIcon,
                crosshairPrefab = rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Void,
                shotCount = 30,
                primarySkillDef = Survivors.Driver.plasmaCannonPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.plasmaCannonSecondarySkillDef,
                mesh = Assets.plasmaCannonMesh,
                material = Assets.plasmaCannonMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_laser",
                configIdentifier = "Super Plasma Cannon"
            });
            DriverWeaponCatalog.AddWeapon(plasmaCannonWeaponDef);
            DriverWeaponCatalog.PlasmaCannon = plasmaCannonWeaponDef;

            badassShotgunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_BADASS_SHOTGUN_NAME",
                descriptionToken = "ROB_DRIVER_BADASS_SHOTGUN_DESC",
                icon = Assets.badassShotgunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("SMG"),
                tier = DriverWeaponTier.Legendary,
                shotCount = 10,
                primarySkillDef = Survivors.Driver.badassShotgunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.badassShotgunSecondarySkillDef,
                mesh = Assets.badassShotgunMesh,
                material = Assets.badassShotgunMat,
                animationSet = DriverWeaponDef.AnimationSet.Default,
                calloutSoundString = "sfx_driver_callout_shotgun",
                configIdentifier = "Badass Shotgun"
            });
            DriverWeaponCatalog.AddWeapon(badassShotgunWeaponDef);

            lunarRifleWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_LUNARRIFLE_NAME",
                descriptionToken = "ROB_DRIVER_LUNARRIFLE_DESC",
                icon = Assets.lunarRifleWeaponIcon,
                crosshairPrefab = Assets.rocketLauncherCrosshairPrefab,
                tier = DriverWeaponTier.Lunar,
                shotCount = 16,
                primarySkillDef = Survivors.Driver.lunarRiflePrimarySkillDef,
                secondarySkillDef = Survivors.Driver.lunarRifleSecondarySkillDef,
                mesh = Assets.lunarRifleMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/LunarGolem/matLunarGolem.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_generic",
                configIdentifier = "Chimeric Cannon"
            });
            DriverWeaponCatalog.AddWeapon(lunarRifleWeaponDef);
            DriverWeaponCatalog.LunarRifle = lunarRifleWeaponDef;

            lunarHammerWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_LUNARHAMMER_NAME",
                descriptionToken = "ROB_DRIVER_LUNARHAMMER_DESC",
                icon = Assets.lunarHammerWeaponIcon,
                crosshairPrefab = Assets.needlerCrosshairPrefab,
                tier = DriverWeaponTier.Lunar,
                primarySkillDef = Survivors.Driver.lunarHammerPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.lunarHammerSecondarySkillDef,
                mesh = Assets.lunarHammerMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Brother/matBrotherHammer.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.BigMelee,
                calloutSoundString = "sfx_driver_callout_generic"
            });
            DriverWeaponCatalog.AddWeapon(lunarHammerWeaponDef);
            DriverWeaponCatalog.LunarHammer = lunarHammerWeaponDef;

            nemmandoGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_NEMMANDO_NAME",
                descriptionToken = "ROB_DRIVER_NEMMANDO_DESC",
                icon = Assets.nemmandoGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("Standard"),
                tier = DriverWeaponTier.Void,
                shotCount = 64,
                primarySkillDef = Survivors.Driver.nemmandoGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.nemmandoGunSecondarySkillDef,
                mesh = Assets.nemmandoGunMesh,
                material = Assets.nemmandoGunMat,
                animationSet = DriverWeaponDef.AnimationSet.Default,
                calloutSoundString = "sfx_driver_callout_generic"
            });
            DriverWeaponCatalog.AddWeapon(nemmandoGunWeaponDef);
            DriverWeaponCatalog.NemmandoGun = nemmandoGunWeaponDef;

            nemmercGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_NEMMERC_NAME",
                descriptionToken = "ROB_DRIVER_NEMMERC_DESC",
                icon = Assets.nemmercGunWeaponIcon,
                crosshairPrefab = Assets.LoadCrosshair("SMG"),
                tier = DriverWeaponTier.Void,
                shotCount = 48,
                primarySkillDef = Survivors.Driver.nemmercGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.nemmercGunSecondarySkillDef,
                mesh = Assets.nemmercGunMesh,
                material = Assets.nemmercGunMat,
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_shotgun"
            });
            DriverWeaponCatalog.AddWeapon(nemmercGunWeaponDef);
            DriverWeaponCatalog.NemmercGun = nemmercGunWeaponDef;

            golemGunWeaponDef = DriverWeaponDef.CreateWeaponDefFromInfo(new DriverWeaponDefInfo
            {
                nameToken = "ROB_DRIVER_GOLEMGUN_NAME",
                descriptionToken = "ROB_DRIVER_GOLEMGUN_DESC",
                icon = Assets.golemGunWeaponIcon,
                crosshairPrefab = circleCrosshairPrefab,
                tier = DriverWeaponTier.Unique,
                shotCount = 24,
                primarySkillDef = Survivors.Driver.golemGunPrimarySkillDef,
                secondarySkillDef = Survivors.Driver.golemGunSecondarySkillDef,
                mesh = Assets.golemGunMesh,
                material = Addressables.LoadAssetAsync<Material>("RoR2/Base/Golem/matGolem.mat").WaitForCompletion(),
                animationSet = DriverWeaponDef.AnimationSet.TwoHanded,
                calloutSoundString = "sfx_driver_callout_generic",
                configIdentifier = "Stone Cannon"
            });
            DriverWeaponCatalog.AddWeapon(golemGunWeaponDef);
            DriverWeaponCatalog.GolemRifle = golemGunWeaponDef;
        }

        private static GameObject CreateCrosshair()
        {
            GameObject crosshairPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandit2/Bandit2CrosshairPrepRevolver.prefab").WaitForCompletion().InstantiateClone("AliemCrosshair", false);
            CrosshairController crosshair = crosshairPrefab.GetComponent<CrosshairController>();
            crosshair.skillStockSpriteDisplays = new CrosshairController.SkillStockSpriteDisplay[0];

            DriverPlugin.DestroyImmediate(crosshairPrefab.transform.Find("Outer").GetComponent<ObjectScaleCurve>());
            crosshairPrefab.transform.Find("Outer").GetComponent<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/Base/UI/texCrosshairTridant.png").WaitForCompletion();
            RectTransform rectR = crosshairPrefab.transform.Find("Outer").GetComponent<RectTransform>();
            rectR.localScale = Vector3.one * 0.75f;

            GameObject nibL = GameObject.Instantiate(crosshair.transform.Find("Outer").gameObject);
            nibL.transform.parent = crosshairPrefab.transform;
            //nibL.GetComponent<Image>().sprite = Addressables.LoadAssetAsync<Sprite>("RoR2/DLC1/Railgunner/texCrosshairRailgunSniperCenter.png").WaitForCompletion();
            RectTransform rectL = nibL.GetComponent<RectTransform>();
            rectL.localEulerAngles = new Vector3(0f, 0f, 180f);

            crosshair.spriteSpreadPositions = new CrosshairController.SpritePosition[]
            {
                new CrosshairController.SpritePosition
                {
                    target = rectR,
                    zeroPosition = new Vector3(0f, 0f, 0f),
                    onePosition = new Vector3(10f, 10f, 0f)
                },
                new CrosshairController.SpritePosition
                {
                    target = rectL,
                    zeroPosition = new Vector3(0f, 0f, 0f),
                    onePosition = new Vector3(-10f, -10f, 0f)
                }
            };

            crosshairPrefab.AddComponent<RobDriver.Modules.Components.CrosshairRotator>();

            return crosshairPrefab;
        }

        internal static GameObject CreateTextPopupEffect(string prefabName, string token, string soundName = "")
        {
            GameObject i = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/BearProc").InstantiateClone(prefabName, true);

            i.GetComponent<EffectComponent>().soundName = soundName;
            if (!i.GetComponent<NetworkIdentity>()) i.AddComponent<NetworkIdentity>();

            i.GetComponentInChildren<RoR2.UI.LanguageTextMeshController>().token = token;

            Assets.AddNewEffectDef(i);

            return i;
        }

        internal static NetworkSoundEventDef CreateNetworkSoundEventDef(string eventName)
        {
            NetworkSoundEventDef networkSoundEventDef = ScriptableObject.CreateInstance<NetworkSoundEventDef>();
            networkSoundEventDef.akId = AkSoundEngine.GetIDFromString(eventName);
            networkSoundEventDef.eventName = eventName;

            networkSoundEventDefs.Add(networkSoundEventDef);

            return networkSoundEventDef;
        }

        internal static void ConvertAllRenderersToHopooShader(GameObject objectToConvert)
        {
            foreach (Renderer i in objectToConvert.GetComponentsInChildren<Renderer>())
            {
                if (i)
                {
                    if (i.material)
                    {
                        i.material.shader = hotpoo;
                    }
                }
            }
        }

        internal static CharacterModel.RendererInfo[] SetupRendererInfos(GameObject obj)
        {
            MeshRenderer[] meshes = obj.GetComponentsInChildren<MeshRenderer>();
            CharacterModel.RendererInfo[] rendererInfos = new CharacterModel.RendererInfo[meshes.Length];

            for (int i = 0; i < meshes.Length; i++)
            {
                rendererInfos[i] = new CharacterModel.RendererInfo
                {
                    defaultMaterial = meshes[i].material,
                    renderer = meshes[i],
                    defaultShadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On,
                    ignoreOverlays = false
                };
            }

            return rendererInfos;
        }

        public static GameObject LoadSurvivorModel(string modelName) {
            GameObject model = mainAssetBundle.LoadAsset<GameObject>(modelName);
            if (model == null) {
                Log.Error("Trying to load a null model- check to see if the name in your code matches the name of the object in Unity");
                return null;
            }

            return PrefabAPI.InstantiateClone(model, model.name, false);
        }

        internal static Texture LoadCharacterIcon(string characterName)
        {
            return mainAssetBundle.LoadAsset<Texture>("tex" + characterName + "Icon");
        }

        internal static GameObject LoadCrosshair(string crosshairName)
        {
            return Resources.Load<GameObject>("Prefabs/Crosshair/" + crosshairName + "Crosshair");
        }

        private static GameObject LoadEffect(string resourceName)
        {
            return LoadEffect(resourceName, "", false);
        }

        private static GameObject LoadEffect(string resourceName, string soundName)
        {
            return LoadEffect(resourceName, soundName, false);
        }

        private static GameObject LoadEffect(string resourceName, bool parentToTransform)
        {
            return LoadEffect(resourceName, "", parentToTransform);
        }

        private static GameObject LoadEffect(string resourceName, string soundName, bool parentToTransform)
        {
            GameObject newEffect = mainAssetBundle.LoadAsset<GameObject>(resourceName);

            newEffect.AddComponent<DestroyOnTimer>().duration = 12;
            newEffect.AddComponent<NetworkIdentity>();
            newEffect.AddComponent<VFXAttributes>().vfxPriority = VFXAttributes.VFXPriority.Always;
            var effect = newEffect.AddComponent<EffectComponent>();
            effect.applyScale = false;
            effect.effectIndex = EffectIndex.Invalid;
            effect.parentToReferencedTransform = parentToTransform;
            effect.positionAtReferencedTransform = true;
            effect.soundName = soundName;

            AddNewEffectDef(newEffect, soundName);

            return newEffect;
        }

        internal static void AddNewEffectDef(GameObject effectPrefab)
        {
            AddNewEffectDef(effectPrefab, "");
        }

        internal static void AddNewEffectDef(GameObject effectPrefab, string soundName)
        {
            EffectDef newEffectDef = new EffectDef();
            newEffectDef.prefab = effectPrefab;
            newEffectDef.prefabEffectComponent = effectPrefab.GetComponent<EffectComponent>();
            newEffectDef.prefabName = effectPrefab.name;
            newEffectDef.prefabVfxAttributes = effectPrefab.GetComponent<VFXAttributes>();
            newEffectDef.spawnSoundEventName = soundName;

            effectDefs.Add(newEffectDef);
        }

        public static Material CreateMaterial(string materialName, float emission, Color emissionColor, float normalStrength)
        {
            if (!commandoMat) commandoMat = Resources.Load<GameObject>("Prefabs/CharacterBodies/CommandoBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[0].defaultMaterial;

            Material mat = UnityEngine.Object.Instantiate<Material>(commandoMat);
            Material tempMat = Assets.mainAssetBundle.LoadAsset<Material>(materialName);

            if (!tempMat) return commandoMat;

            mat.name = materialName;
            mat.SetColor("_Color", tempMat.GetColor("_Color"));
            mat.SetTexture("_MainTex", tempMat.GetTexture("_MainTex"));
            mat.SetColor("_EmColor", emissionColor);
            mat.SetFloat("_EmPower", emission);
            mat.SetTexture("_EmTex", tempMat.GetTexture("_EmissionMap"));
            mat.SetFloat("_NormalStrength", normalStrength);

            return mat;
        }

        public static Material CreateMaterial(string materialName)
        {
            return Assets.CreateMaterial(materialName, 0f);
        }

        public static Material CreateMaterial(string materialName, float emission)
        {
            return Assets.CreateMaterial(materialName, emission, Color.black);
        }

        public static Material CreateMaterial(string materialName, float emission, Color emissionColor)
        {
            return Assets.CreateMaterial(materialName, emission, emissionColor, 0f);
        }
    }
}