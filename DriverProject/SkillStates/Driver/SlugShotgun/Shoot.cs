﻿using RoR2;
using UnityEngine;
using EntityStates;
using RobDriver.Modules.Components;

namespace RobDriver.SkillStates.Driver.SlugShotgun
{
    public class Shoot : BaseDriverSkillState
    {
        public const float RAD2 = 1.414f;

        public static float damageCoefficient = 9f;
        public static float procCoefficient = 1f;
        public float baseDuration = 1.6f;
        public static int bulletCount = 1;
        public static float bulletSpread = 2f;
        public static float bulletRecoil = 8f;
        public static float bulletRange = 80f;
        public static float bulletThiccness = 1f;
        public float selfForce = 2000f;

        private float earlyExitTime;
        protected float duration;
        protected float fireDuration;
        protected bool hasFired;
        private bool isCrit;
        protected string muzzleString;

        public override void OnEnter()
        {
            base.OnEnter();
            this.characterBody.SetAimTimer(5f);
            this.muzzleString = "ShotgunMuzzle";
            this.hasFired = false;
            this.duration = this.baseDuration / this.attackSpeedStat;
            this.isCrit = base.RollCrit();
            this.earlyExitTime = 0.75f * this.duration;

            if (this.isCrit) Util.PlaySound("sfx_driver_slug_shotgun_shoot_critical", base.gameObject);
            else Util.PlaySound("sfx_driver_slug_shotgun_shoot", base.gameObject);

            base.PlayAnimation("Gesture, Override", "FireRiotShotgun", "Shoot.playbackRate", this.duration);

            this.fireDuration = 0;

            if (this.iDrive) this.iDrive.StartTimer();
        }

        public virtual void FireBullet()
        {
            if (!this.hasFired)
            {
                this.hasFired = true;

                if (this.iDrive)
                {
                    this.iDrive.DropSlug(-this.GetModelBaseTransform().transform.right * -Random.Range(4, 12));
                }

                float recoilAmplitude = Shoot.bulletRecoil / this.attackSpeedStat;

                base.AddRecoil(-0.4f * recoilAmplitude, -0.8f * recoilAmplitude, -0.3f * recoilAmplitude, 0.3f * recoilAmplitude);
                this.characterBody.AddSpreadBloom(4f);
                EffectManager.SimpleMuzzleFlash(EntityStates.Commando.CommandoWeapon.FireBarrage.effectPrefab, gameObject, muzzleString, false);

                GameObject tracer = Modules.Assets.shotgunTracer;
                if (this.isCrit) tracer = Modules.Assets.shotgunTracerCrit;

                if (base.isAuthority)
                {
                    float damage = Shoot.damageCoefficient * this.damageStat;

                    Ray aimRay = GetAimRay();

                    float spread = Shoot.bulletSpread;
                    float thiccness = Shoot.bulletThiccness;
                    float force = 2500;

                    BulletAttack bulletAttack = new BulletAttack
                    {
                        aimVector = aimRay.direction,
                        origin = aimRay.origin,
                        damage = damage,
                        damageColorIndex = DamageColorIndex.Default,
                        damageType = DamageType.Generic,
                        falloffModel = BulletAttack.FalloffModel.None,
                        maxDistance = bulletRange,
                        force = force,
                        hitMask = LayerIndex.CommonMasks.bullet,
                        isCrit = this.isCrit,
                        owner = gameObject,
                        muzzleName = muzzleString,
                        smartCollision = true,
                        procChainMask = default,
                        procCoefficient = procCoefficient,
                        radius = thiccness,
                        sniper = false,
                        stopperMask = LayerIndex.CommonMasks.bullet,
                        weapon = null,
                        tracerEffectPrefab = tracer,
                        spreadPitchScale = 1f,
                        spreadYawScale = 1f,
                        queryTriggerInteraction = QueryTriggerInteraction.UseGlobal,
                        hitEffectPrefab = EntityStates.Commando.CommandoWeapon.FireBarrage.hitEffectPrefab,
                        HitEffectNormal = false,
                    };

                    bulletAttack.minSpread = 0;
                    bulletAttack.maxSpread = 0;
                    bulletAttack.bulletCount = 1;
                    bulletAttack.Fire();

                    uint secondShot = (uint)Mathf.CeilToInt(bulletCount / 2f) - 1;
                    bulletAttack.minSpread = 0;
                    bulletAttack.maxSpread = spread / 1.45f;
                    bulletAttack.bulletCount = secondShot;
                    bulletAttack.Fire();

                    bulletAttack.minSpread = spread / 1.45f;
                    bulletAttack.maxSpread = spread;
                    bulletAttack.bulletCount = (uint)Mathf.FloorToInt(bulletCount / 2f);
                    bulletAttack.Fire();

                    this.characterMotor.ApplyForce((aimRay.direction * -this.selfForce) / this.attackSpeedStat);
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.fixedAge >= this.fireDuration)
            {
                this.FireBullet();
            }

            if (this.iDrive && this.iDrive.weaponDef != this.cachedWeaponDef)
            {
                base.PlayAnimation("Gesture, Override", this.iDrive.weaponDef.equipAnimationString);
                this.outer.SetNextStateToMain();
                return;
            }

            if (base.fixedAge >= this.duration && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            if (base.fixedAge >= this.earlyExitTime) return InterruptPriority.Any;
            return InterruptPriority.Skill;
        }
    }
}