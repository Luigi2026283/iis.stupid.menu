using System;
using System.Collections;
using System.Collections.Generic;
using BepInEx;
using GorillaLocomotion;
using UnityEngine;

namespace iiMenu.Mods
{
    public static class Detected
    {
        public static void AutoSetMasterClient() { }
        public static void AutoSetMasterClient(params object[] args) { }
        public static void BanAura() { }
        public static void BanAura(params object[] args) { }
        public static void BanGun() { }
        public static void BanGun(params object[] args) { }
        public static void BanOnTouch() { }
        public static void BanOnTouch(params object[] args) { }
        public static void BreakGamemode() { }
        public static void BreakGamemode(params object[] args) { }
        public static void BreakModCheckersAll() { }
        public static void BreakModCheckersAll(params object[] args) { }
        public static void BreakModCheckersAura() { }
        public static void BreakModCheckersAura(params object[] args) { }
        public static void BreakModCheckersGun() { }
        public static void BreakModCheckersGun(params object[] args) { }
        public static void BreakModCheckersOnTouch() { }
        public static void BreakModCheckersOnTouch(params object[] args) { }
        public static void BreakNetworkTriggers() { }
        public static void BreakNetworkTriggers(params object[] args) { }
        public static void BypassModCheckersAll() { }
        public static void BypassModCheckersAll(params object[] args) { }
        public static void BypassModCheckersAura() { }
        public static void BypassModCheckersAura(params object[] args) { }
        public static void BypassModCheckersGun() { }
        public static void BypassModCheckersGun(params object[] args) { }
        public static void BypassModCheckersOnTouch() { }
        public static void BypassModCheckersOnTouch(params object[] args) { }
        public static void ChangeGamemode() { }
        public static void ChangeGamemode(params object[] args) { }
        public static void ChangeNameAll() { }
        public static void ChangeNameAll(params object[] args) { }
        public static void ChangeNameAura() { }
        public static void ChangeNameAura(params object[] args) { }
        public static void ChangeNameGun() { }
        public static void ChangeNameGun(params object[] args) { }
        public static void ChangeNameOnTouch() { }
        public static void ChangeNameOnTouch(params object[] args) { }
        public static void CrashAll() { }
        public static void CrashAll(params object[] args) { }
        public static void CrashAura() { }
        public static void CrashAura(params object[] args) { }
        public static void CrashGun() { }
        public static void CrashGun(params object[] args) { }
        public static void CrashOnTouch() { }
        public static void CrashOnTouch(params object[] args) { }
        public static void CrashWhenTouched() { }
        public static void CrashWhenTouched(params object[] args) { }
        public static void DisableLeaderboardGhost() { }
        public static void DisableLeaderboardGhost(params object[] args) { }
        public static void EnterDetectedTab() { }
        public static void EnterDetectedTab(params object[] args) { }
        public static void GamemodeExcludeAll() { }
        public static void GamemodeExcludeAll(params object[] args) { }
        public static void GamemodeExcludeAura() { }
        public static void GamemodeExcludeAura(params object[] args) { }
        public static void GamemodeExcludeGun() { }
        public static void GamemodeExcludeGun(params object[] args) { }
        public static void GamemodeExcludeOnTouch() { }
        public static void GamemodeExcludeOnTouch(params object[] args) { }
        public static void GamemodeIncludeAll() { }
        public static void GamemodeIncludeAll(params object[] args) { }
        public static void GamemodeIncludeAura() { }
        public static void GamemodeIncludeAura(params object[] args) { }
        public static void GamemodeIncludeGun() { }
        public static void GamemodeIncludeGun(params object[] args) { }
        public static void GamemodeIncludeOnTouch() { }
        public static void GamemodeIncludeOnTouch(params object[] args) { }
        public static void GhostAll() { }
        public static void GhostAll(params object[] args) { }
        public static void GhostAura() { }
        public static void GhostAura(params object[] args) { }
        public static void GhostGun() { }
        public static void GhostGun(params object[] args) { }
        public static void GhostOnTouch() { }
        public static void GhostOnTouch(params object[] args) { }
        public static void IsolateAll() { }
        public static void IsolateAll(params object[] args) { }
        public static void IsolateAura() { }
        public static void IsolateAura(params object[] args) { }
        public static void IsolateGun() { }
        public static void IsolateGun(params object[] args) { }
        public static void IsolateOnTouch() { }
        public static void IsolateOnTouch(params object[] args) { }
        public static void KickNetworkTriggers() { }
        public static void KickNetworkTriggers(params object[] args) { }
        public static void LagAll() { }
        public static void LagAll(params object[] args) { }
        public static void LagAura() { }
        public static void LagAura(params object[] args) { }
        public static void LagGun() { }
        public static void LagGun(params object[] args) { }
        public static void LagOnTouch() { }
        public static void LagOnTouch(params object[] args) { }
        public static void LeaderboardGhost() { }
        public static void LeaderboardGhost(params object[] args) { }
        public static void LeaderboardMute() { }
        public static void LeaderboardMute(params object[] args) { }
        public static dynamic moddedGamemode;
        public static void MuteAll() { }
        public static void MuteAll(params object[] args) { }
        public static void MuteAura() { }
        public static void MuteAura(params object[] args) { }
        public static void MuteGun() { }
        public static void MuteGun(params object[] args) { }
        public static void MuteOnTouch() { }
        public static void MuteOnTouch(params object[] args) { }
        public static void PromptNameChange() { }
        public static void PromptNameChange(params object[] args) { }
        public static void SetMasterClientAll() { }
        public static void SetMasterClientAll(params object[] args) { }
        public static void SetMasterClientAura() { }
        public static void SetMasterClientAura(params object[] args) { }
        public static void SetMasterClientGun() { }
        public static void SetMasterClientGun(params object[] args) { }
        public static void SetMasterClientOnTouch() { }
        public static void SetMasterClientOnTouch(params object[] args) { }
        public static void SpazGamemode() { }
        public static void SpazGamemode(params object[] args) { }
        public static void UnghostAll() { }
        public static void UnghostAll(params object[] args) { }
        public static void UnghostAura() { }
        public static void UnghostAura(params object[] args) { }
        public static void UnghostGun() { }
        public static void UnghostGun(params object[] args) { }
        public static void UnghostOnTouch() { }
        public static void UnghostOnTouch(params object[] args) { }
    }

    public static class Experimental
    {
        public static void AdminABlockGun() { }
        public static void AdminABlockGun(params object[] args) { }
        public static void AdminBeam() { }
        public static void AdminBeam(params object[] args) { }
        public static void AdminBlockGun() { }
        public static void AdminBlockGun(params object[] args) { }
        public static void AdminBMuteAll() { }
        public static void AdminBMuteAll(params object[] args) { }
        public static void AdminBMuteGun() { }
        public static void AdminBMuteGun(params object[] args) { }
        public static void AdminBringGun() { }
        public static void AdminBringGun(params object[] args) { }
        public static void AdminButtonPressGun() { }
        public static void AdminButtonPressGun(params object[] args) { }
        public static void AdminCrashAll() { }
        public static void AdminCrashAll(params object[] args) { }
        public static void AdminCrashBypassGun() { }
        public static void AdminCrashBypassGun(params object[] args) { }
        public static void AdminCrashGun() { }
        public static void AdminCrashGun(params object[] args) { }
        public static void AdminEnableGun() { }
        public static void AdminEnableGun(params object[] args) { }
        public static void AdminFearGun() { }
        public static void AdminFearGun(params object[] args) { }
        public static void AdminFindUser() { }
        public static void AdminFindUser(params object[] args) { }
        public static void AdminFlingGun() { }
        public static void AdminFlingGun(params object[] args) { }
        public static void AdminFractals() { }
        public static void AdminFractals(params object[] args) { }
        public static void AdminFreezeGun() { }
        public static void AdminFreezeGun(params object[] args) { }
        public static void AdminFullLockdownAll() { }
        public static void AdminFullLockdownAll(params object[] args) { }
        public static void AdminFullLockdownGun() { }
        public static void AdminFullLockdownGun(params object[] args) { }
        public static void AdminGiveFlyGun() { }
        public static void AdminGiveFlyGun(params object[] args) { }
        public static void AdminGiveLowGravity() { }
        public static void AdminGiveLowGravity(params object[] args) { }
        public static void AdminGivePlatforms() { }
        public static void AdminGivePlatforms(params object[] args) { }
        public static void AdminGiveSpeedGun() { }
        public static void AdminGiveSpeedGun(params object[] args) { }
        public static void AdminGiveTriggerFlyGun() { }
        public static void AdminGiveTriggerFlyGun(params object[] args) { }
        public static void AdminIndicatorBack() { }
        public static void AdminIndicatorBack(params object[] args) { }
        public static void AdminJumpscareAll() { }
        public static void AdminJumpscareAll(params object[] args) { }
        public static void AdminJumpscareGun() { }
        public static void AdminJumpscareGun(params object[] args) { }
        public static void AdminKickAll() { }
        public static void AdminKickAll(params object[] args) { }
        public static void AdminKickGun() { }
        public static void AdminKickGun(params object[] args) { }
        public static void AdminLagAll() { }
        public static void AdminLagAll(params object[] args) { }
        public static void AdminLagGun() { }
        public static void AdminLagGun(params object[] args) { }
        public static void AdminLagSpikeAll() { }
        public static void AdminLagSpikeAll(params object[] args) { }
        public static void AdminLagSpikeGun() { }
        public static void AdminLagSpikeGun(params object[] args) { }
        public static void AdminLaser() { }
        public static void AdminLaser(params object[] args) { }
        public static void AdminLockdownAll() { }
        public static void AdminLockdownAll(params object[] args) { }
        public static void AdminLockdownGun() { }
        public static void AdminLockdownGun(params object[] args) { }
        public static void AdminMenuUserTags() { }
        public static void AdminMenuUserTags(params object[] args) { }
        public static void AdminMute() { }
        public static void AdminMute(params object[] args) { }
        public static void AdminNetworkScale() { }
        public static void AdminNetworkScale(params object[] args) { }
        public static void AdminObjectGun() { }
        public static void AdminObjectGun(params object[] args) { }
        public static void AdminOrganizeGun() { }
        public static void AdminOrganizeGun(params object[] args) { }
        public static void AdminPlatToggleGun() { }
        public static void AdminPlatToggleGun(params object[] args) { }
        public static void AdminPunchMod() { }
        public static void AdminPunchMod(params object[] args) { }
        public static void AdminRandomObjectGun() { }
        public static void AdminRandomObjectGun(params object[] args) { }
        public static void AdminSpoofCosmetics() { }
        public static void AdminSpoofCosmetics(params object[] args) { }
        public static void AdminStrangle() { }
        public static void AdminStrangle(params object[] args) { }
        public static void AdminTeleportGun() { }
        public static void AdminTeleportGun(params object[] args) { }
        public static void AdminVibrateAll() { }
        public static void AdminVibrateAll(params object[] args) { }
        public static void AdminVibrateGun() { }
        public static void AdminVibrateGun(params object[] args) { }
        public static void AutoSetMaster() { }
        public static void AutoSetMaster(params object[] args) { }
        public static void BetterFPSBoost() { }
        public static void BetterFPSBoost(params object[] args) { }
        public static void BlankPage() { }
        public static void BlankPage(params object[] args) { }
        public static void BouncyAllUsing() { }
        public static void BouncyAllUsing(params object[] args) { }
        public static void BringAllUsing() { }
        public static void BringAllUsing(params object[] args) { }
        public static void BringHandAllUsing() { }
        public static void BringHandAllUsing(params object[] args) { }
        public static void BringHeadAllUsing() { }
        public static void BringHeadAllUsing(params object[] args) { }
        public static void ChangeNameAll() { }
        public static void ChangeNameAll(params object[] args) { }
        public static void ChangeNameGun() { }
        public static void ChangeNameGun(params object[] args) { }
        public static void ConfirmNotifyAllUsing() { }
        public static void ConfirmNotifyAllUsing(params object[] args) { }
        public static void ConsoleOnConduct() { }
        public static void ConsoleOnConduct(params object[] args) { }
        public static void CopyCustomGamemodeScript() { }
        public static void CopyCustomGamemodeScript(params object[] args) { }
        public static void CopyCustomMapID() { }
        public static void CopyCustomMapID(params object[] args) { }
        public static void CrashAll() { }
        public static void CrashAll(params object[] args) { }
        public static void CrashGun() { }
        public static void CrashGun(params object[] args) { }
        public static void DecryptableCosmeticData() { }
        public static void DecryptableCosmeticData(params object[] args) { }
        public static void DisableAdminMenuUserTags() { }
        public static void DisableAdminMenuUserTags(params object[] args) { }
        public static void DisableBetterFPSBoost() { }
        public static void DisableBetterFPSBoost(params object[] args) { }
        public static void DumpCosmeticData() { }
        public static void DumpCosmeticData(params object[] args) { }
        public static void DumpRPCData() { }
        public static void DumpRPCData(params object[] args) { }
        public static void DumpSoundData() { }
        public static void DumpSoundData(params object[] args) { }
        public static void EnableAdminMenuUserTags() { }
        public static void EnableAdminMenuUserTags(params object[] args) { }
        public static void EnableAdminMenuUserTracers() { }
        public static void EnableAdminMenuUserTracers(params object[] args) { }
        public static void EnableNoAdminIndicator() { }
        public static void EnableNoAdminIndicator(params object[] args) { }
        public static dynamic FindUserTime;
        public static void FixDuplicateButtons() { }
        public static void FixDuplicateButtons(params object[] args) { }
        public static void FlipMenuGun() { }
        public static void FlipMenuGun(params object[] args) { }
        public static void FlyAllUsing() { }
        public static void FlyAllUsing(params object[] args) { }
        public static void GetMenuUsers() { }
        public static void GetMenuUsers(params object[] args) { }
        public static void GetTargetNotification() { }
        public static void GetTargetNotification(params object[] args) { }
        public static void JoinAll() { }
        public static void JoinAll(params object[] args) { }
        public static void JoinGun() { }
        public static void JoinGun(params object[] args) { }
        public static void LagAll() { }
        public static void LagAll(params object[] args) { }
        public static void LagGun() { }
        public static void LagGun(params object[] args) { }
        public static void LightningAura() { }
        public static void LightningAura(params object[] args) { }
        public static void LightningGun() { }
        public static void LightningGun(params object[] args) { }
        public static void LightningRain() { }
        public static void LightningRain(params object[] args) { }
        public static void MenuUserTracers() { }
        public static void MenuUserTracers(params object[] args) { }
        public static void NoAdminIndicator() { }
        public static void NoAdminIndicator(params object[] args) { }
        public static void NotifyAll() { }
        public static void NotifyAll(params object[] args) { }
        public static void NotifyGun() { }
        public static void NotifyGun(params object[] args) { }
        public static void NotifySelf() { }
        public static void NotifySelf(params object[] args) { }
        public static string[] oldCosmetics;
        public static void OnlySerializeNecessary() { }
        public static void OnlySerializeNecessary(params object[] args) { }
        public static void OnPlayerJoinSpoof(NetPlayer player) { }
        public static void OnPlayerJoinSpoof(params object[] args) { }
        public static void OrbitAllUsing() { }
        public static void OrbitAllUsing(params object[] args) { }
        public static dynamic platExcluded;
        public static dynamic restartDelay;
        public static dynamic restartIndex;
        public static void SafeRestartGame() { }
        public static void SafeRestartGame(params object[] args) { }
        public static void UnAdminNetworkScale() { }
        public static void UnAdminNetworkScale(params object[] args) { }
    }

    public static class Fun
    {
        public static void ActivateAllDoors() { }
        public static void ActivateAllDoors(params object[] args) { }
        public static void AddCurrencyAll() { }
        public static void AddCurrencyAll(params object[] args) { }
        public static void AddCurrencyGun() { }
        public static void AddCurrencyGun(params object[] args) { }
        public static void AddCurrencySelf() { }
        public static void AddCurrencySelf(params object[] args) { }
        public static void AngerBees() { }
        public static void AngerBees(params object[] args) { }
        public static void AngerBeesAll() { }
        public static void AngerBeesAll(params object[] args) { }
        public static void AngerBeesGun() { }
        public static void AngerBeesGun(params object[] args) { }
        public static void AngryBirdsSounds() { }
        public static void AngryBirdsSounds(params object[] args) { }
        public static void AnimatedName() { }
        public static void AnimatedName(params object[] args) { }
        public static void ArcadeTeleporterEffectSpam() { }
        public static void ArcadeTeleporterEffectSpam(params object[] args) { }
        public static void AtticAntiReport() { }
        public static void AtticAntiReport(params object[] args) { }
        public static void AtticBringGun() { }
        public static void AtticBringGun(params object[] args) { }
        public static void AtticBuildGun() { }
        public static void AtticBuildGun(params object[] args) { }
        public static void AtticDrawGun() { }
        public static void AtticDrawGun(params object[] args) { }
        public static void AtticFlingGun() { }
        public static void AtticFlingGun(params object[] args) { }
        public static void AtticFloatAll() { }
        public static void AtticFloatAll(params object[] args) { }
        public static void AtticFloatGun() { }
        public static void AtticFloatGun(params object[] args) { }
        public static void AtticFreezeAll() { }
        public static void AtticFreezeAll(params object[] args) { }
        public static void AtticFreezeGun() { }
        public static void AtticFreezeGun(params object[] args) { }
        public static void AtticPushGun() { }
        public static void AtticPushGun(params object[] args) { }
        public static void AtticSizeToggle() { }
        public static void AtticSizeToggle(params object[] args) { }
        public static void AtticTowerGun() { }
        public static void AtticTowerGun(params object[] args) { }
        public static void AutoClicker() { }
        public static void AutoClicker(params object[] args) { }
        public static void AutoHitMoleType() { }
        public static void AutoHitMoleType(params object[] args) { }
        public static void AutoLoadCosmetics() { }
        public static void AutoLoadCosmetics(params object[] args) { }
        public static void AutoPurchaseCosmetics() { }
        public static void AutoPurchaseCosmetics(params object[] args) { }
        public static void AutoPurchasePaidCosmetics() { }
        public static void AutoPurchasePaidCosmetics(params object[] args) { }
        public static void AutoStartMoles() { }
        public static void AutoStartMoles(params object[] args) { }
        public static void BackwardsHead() { }
        public static void BackwardsHead(params object[] args) { }
        public static void BalloonAura() { }
        public static void BalloonAura(params object[] args) { }
        public static void BalloonGun() { }
        public static void BalloonGun(params object[] args) { }
        public static void BasementDoorSpam() { }
        public static void BasementDoorSpam(params object[] args) { }
        public static void BecomeBalloon() { }
        public static void BecomeBalloon(params object[] args) { }
        public static void BecomeCamera() { }
        public static void BecomeCamera(params object[] args) { }
        public static void BecomeHoverboard() { }
        public static void BecomeHoverboard(params object[] args) { }
        public static void BecomeMinigamesKid() { }
        public static void BecomeMinigamesKid(params object[] args) { }
        public static void BecomeObject() { }
        public static void BecomeObject(params object[] args) { }
        public static void BecomePlayer() { }
        public static void BecomePlayer(params object[] args) { }
        public static void BecomeTablet() { }
        public static void BecomeTablet(params object[] args) { }
        public static void BetaWaterSplash() { }
        public static void BetaWaterSplash(params object[] args) { }
        public static void BlackColorGun() { }
        public static void BlackColorGun(params object[] args) { }
        public static void BlackColorTarget() { }
        public static void BlackColorTarget(params object[] args) { }
        public static void BlockBrowser() { }
        public static void BlockBrowser(params object[] args) { }
        public static dynamic blockDebounceIndex;
        public static void BlocksGun() { }
        public static void BlocksGun(params object[] args) { }
        public static void Boop() { }
        public static void Boop(params object[] args) { }
        public static void BraceletSpam() { }
        public static void BraceletSpam(params object[] args) { }
        public static void BreakBat() { }
        public static void BreakBat(params object[] args) { }
        public static void BreakBug() { }
        public static void BreakBug(params object[] args) { }
        public static void BreakModCheckers() { }
        public static void BreakModCheckers(params object[] args) { }
        public static void BrokenNeck() { }
        public static void BrokenNeck(params object[] args) { }
        public static void BubblerGun() { }
        public static void BubblerGun(params object[] args) { }
        public static void BugPhallus() { }
        public static void BugPhallus(params object[] args) { }
        public static void BugPhallusGun() { }
        public static void BugPhallusGun(params object[] args) { }
        public static void BugSpam() { }
        public static void BugSpam(params object[] args) { }
        public static void BugVibrateAll() { }
        public static void BugVibrateAll(params object[] args) { }
        public static void BugVibrateGun() { }
        public static void BugVibrateGun(params object[] args) { }
        public static void BuildingBlockAura() { }
        public static void BuildingBlockAura(params object[] args) { }
        public static void BuildingBlockFountain() { }
        public static void BuildingBlockFountain(params object[] args) { }
        public static void BuildingBlockMinigun() { }
        public static void BuildingBlockMinigun(params object[] args) { }
        public static void BuildingBlockTextGun() { }
        public static void BuildingBlockTextGun(params object[] args) { }
        public static void BypassAntiReport() { }
        public static void BypassAntiReport(params object[] args) { }
        public static void CameraAura() { }
        public static void CameraAura(params object[] args) { }
        public static void CameraFOV() { }
        public static void CameraFOV(params object[] args) { }
        public static void CameraGun() { }
        public static void CameraGun(params object[] args) { }
        public static void CameraSpam() { }
        public static void CameraSpam(params object[] args) { }
        public static void ChangeAccessories() { }
        public static void ChangeAccessories(params object[] args) { }
        public static void ChangeBlockDelay() { }
        public static void ChangeBlockDelay(params object[] args) { }
        public static void ChangeCustomQuestScore() { }
        public static void ChangeCustomQuestScore(params object[] args) { }
        public static void ChangeCycleDelay() { }
        public static void ChangeCycleDelay(params object[] args) { }
        public static void ChangeHeadSpinSpeed() { }
        public static void ChangeHeadSpinSpeed(params object[] args) { }
        public static void ChangeTargetFOV() { }
        public static void ChangeTargetFOV(params object[] args) { }
        public static void CheckOwnedCosmetic() { }
        public static void CheckOwnedCosmetic(params object[] args) { }
        public static void CheckOwnedThrowable() { }
        public static void CheckOwnedThrowable(params object[] args) { }
        public static void ChickenGun() { }
        public static void ChickenGun(params object[] args) { }
        public static void ChickenTarget() { }
        public static void ChickenTarget(params object[] args) { }
        public static void CopyBlockInfoGun() { }
        public static void CopyBlockInfoGun(params object[] args) { }
        public static void CopyCosmeticsGun() { }
        public static void CopyCosmeticsGun(params object[] args) { }
        public static void CopyCreationDateAll() { }
        public static void CopyCreationDateAll(params object[] args) { }
        public static void CopyCreationDateAura() { }
        public static void CopyCreationDateAura(params object[] args) { }
        public static void CopyCreationDateGun() { }
        public static void CopyCreationDateGun(params object[] args) { }
        public static void CopyCreationDateOnTouch() { }
        public static void CopyCreationDateOnTouch(params object[] args) { }
        public static void CopyCreationDateSelf() { }
        public static void CopyCreationDateSelf(params object[] args) { }
        public static void CopyIDAll() { }
        public static void CopyIDAll(params object[] args) { }
        public static void CopyIDAura() { }
        public static void CopyIDAura(params object[] args) { }
        public static void CopyIdentityGun() { }
        public static void CopyIdentityGun(params object[] args) { }
        public static void CopyIDGun() { }
        public static void CopyIDGun(params object[] args) { }
        public static void CopyIDOnTouch() { }
        public static void CopyIDOnTouch(params object[] args) { }
        public static void CopySelfID() { }
        public static void CopySelfID(params object[] args) { }
        public static void CopyVoiceGun() { }
        public static void CopyVoiceGun(params object[] args) { }
        public static void CosmeticBrowser() { }
        public static void CosmeticBrowser(params object[] args) { }
        public static void CustomModSpoofer() { }
        public static void CustomModSpoofer(params object[] args) { }
        public static void CustomQuestScore() { }
        public static void CustomQuestScore(params object[] args) { }
        public static void CustomVirtualStumpVideo() { }
        public static void CustomVirtualStumpVideo(params object[] args) { }
        public static dynamic cycleSpeedIndex;
        public static void DebugSlingshotAimbot() { }
        public static void DebugSlingshotAimbot(params object[] args) { }
        public static void DeprioritizeVoiceGun() { }
        public static void DeprioritizeVoiceGun(params object[] args) { }
        public static void DestroyBalloons() { }
        public static void DestroyBalloons(params object[] args) { }
        public static void DestroyBlockGun() { }
        public static void DestroyBlockGun(params object[] args) { }
        public static void DestroyBlocks() { }
        public static void DestroyBlocks(params object[] args) { }
        public static void DestroyCamera() { }
        public static void DestroyCamera(params object[] args) { }
        public static void DestroyGliders() { }
        public static void DestroyGliders(params object[] args) { }
        public static void DestroyMonsters() { }
        public static void DestroyMonsters(params object[] args) { }
        public static void DestroyObject() { }
        public static void DestroyObject(params object[] args) { }
        public static void DestroyTablet() { }
        public static void DestroyTablet(params object[] args) { }
        public static void DestroyTrain() { }
        public static void DestroyTrain(params object[] args) { }
        public static void DisableBugSpam() { }
        public static void DisableBugSpam(params object[] args) { }
        public static void DisableCameraSpam() { }
        public static void DisableCameraSpam(params object[] args) { }
        public static void DisableCopyVoice() { }
        public static void DisableCopyVoice(params object[] args) { }
        public static void DisableCosmeticsOnTag() { }
        public static void DisableCosmeticsOnTag(params object[] args) { }
        public static void DisableCustomVirtualStumpVideo() { }
        public static void DisableCustomVirtualStumpVideo(params object[] args) { }
        public static void DisableEverythingSpam() { }
        public static void DisableEverythingSpam(params object[] args) { }
        public static void DisableFreecam() { }
        public static void DisableFreecam(params object[] args) { }
        public static void DisableGlobalHoverboard() { }
        public static void DisableGlobalHoverboard(params object[] args) { }
        public static void DisableKeyboardTracker() { }
        public static void DisableKeyboardTracker(params object[] args) { }
        public static void DisableMaskVoice() { }
        public static void DisableMaskVoice(params object[] args) { }
        public static void DisableNoclipBuilding() { }
        public static void DisableNoclipBuilding(params object[] args) { }
        public static void DisableShaders() { }
        public static void DisableShaders(params object[] args) { }
        public static void DisableSnowballGenitals() { }
        public static void DisableSnowballGenitals(params object[] args) { }
        public static void DisableThrowable() { }
        public static void DisableThrowable(params object[] args) { }
        public static dynamic DisableThrowableCoroutine;
        public static void DisableUnlimitedBuilding() { }
        public static void DisableUnlimitedBuilding(params object[] args) { }
        public static void EchoMicrophone() { }
        public static void EchoMicrophone(params object[] args) { }
        public static void ElevatorDoorSpam() { }
        public static void ElevatorDoorSpam(params object[] args) { }
        public static void EnableAtticAntiReport() { }
        public static void EnableAtticAntiReport(params object[] args) { }
        public static void EnableBugVibrateAll() { }
        public static void EnableBugVibrateAll(params object[] args) { }
        public static void EnableCustomNameCycle() { }
        public static void EnableCustomNameCycle(params object[] args) { }
        public static void EnableKeyboardTracker() { }
        public static void EnableKeyboardTracker(params object[] args) { }
        public static void EnableShaders() { }
        public static void EnableShaders(params object[] args) { }
        public static void EndShift() { }
        public static void EndShift(params object[] args) { }
        public static void EverythingSpam() { }
        public static void EverythingSpam(params object[] args) { }
        public static void FakeFPS() { }
        public static void FakeFPS(params object[] args) { }
        public static void FastHoverboard() { }
        public static void FastHoverboard(params object[] args) { }
        public static void FastMonsters() { }
        public static void FastMonsters(params object[] args) { }
        public static void FastSnowballs() { }
        public static void FastSnowballs(params object[] args) { }
        public static void FastTrain() { }
        public static void FastTrain(params object[] args) { }
        public static void FireSoundSpam() { }
        public static void FireSoundSpam(params object[] args) { }
        public static void FixCameraFOV() { }
        public static void FixCameraFOV(params object[] args) { }
        public static void FixHandTaps() { }
        public static void FixHandTaps(params object[] args) { }
        public static void FixHead() { }
        public static void FixHead(params object[] args) { }
        public static void FixHoverboard() { }
        public static void FixHoverboard(params object[] args) { }
        public static void FixMonsters() { }
        public static void FixMonsters(params object[] args) { }
        public static void FixSnowballs() { }
        public static void FixSnowballs(params object[] args) { }
        public static void FixTrain() { }
        public static void FixTrain(params object[] args) { }
        public static void FlashColor() { }
        public static void FlashColor(params object[] args) { }
        public static void FlashNameTag() { }
        public static void FlashNameTag(params object[] args) { }
        public static void FlipCamera() { }
        public static void FlipCamera(params object[] args) { }
        public static void FlipHands() { }
        public static void FlipHands(params object[] args) { }
        public static void Freecam() { }
        public static void Freecam(params object[] args) { }
        public static void FreezeObject() { }
        public static void FreezeObject(params object[] args) { }
        public static void GetBracelet() { }
        public static void GetBracelet(params object[] args) { }
        public static void GhostReactorFreezeAll() { }
        public static void GhostReactorFreezeAll(params object[] args) { }
        public static void GhostReactorFreezeGun() { }
        public static void GhostReactorFreezeGun(params object[] args) { }
        public static void GiveBuilderWatch() { }
        public static void GiveBuilderWatch(params object[] args) { }
        public static void GiveWaterSplashHandsGun() { }
        public static void GiveWaterSplashHandsGun(params object[] args) { }
        public static void GlassesOnGrip() { }
        public static void GlassesOnGrip(params object[] args) { }
        public static void GliderAura() { }
        public static void GliderAura(params object[] args) { }
        public static void GliderGun() { }
        public static void GliderGun(params object[] args) { }
        public static void GlitchyMicrophone() { }
        public static void GlitchyMicrophone(params object[] args) { }
        public static void GlobalHoverboard() { }
        public static void GlobalHoverboard(params object[] args) { }
        public static void GoldenNameTag() { }
        public static void GoldenNameTag(params object[] args) { }
        public static void GorillaVoice() { }
        public static void GorillaVoice(params object[] args) { }
        public static void GrabAllBlocksNearby() { }
        public static void GrabAllBlocksNearby(params object[] args) { }
        public static void GrabAllSelectedNearby() { }
        public static void GrabAllSelectedNearby(params object[] args) { }
        public static void GrabBalloons() { }
        public static void GrabBalloons(params object[] args) { }
        public static void GrabCamera() { }
        public static void GrabCamera(params object[] args) { }
        public static void GrabGliders() { }
        public static void GrabGliders(params object[] args) { }
        public static void GrabIDCard() { }
        public static void GrabIDCard(params object[] args) { }
        public static void GrabMonsters() { }
        public static void GrabMonsters(params object[] args) { }
        public static void GrabPlayerInfo() { }
        public static void GrabPlayerInfo(params object[] args) { }
        public static void GrabTablet() { }
        public static void GrabTablet(params object[] args) { }
        public static void GrabTrain() { }
        public static void GrabTrain(params object[] args) { }
        public static void HardRainbowColor() { }
        public static void HardRainbowColor(params object[] args) { }
        public static void HeadBang() { }
        public static void HeadBang(params object[] args) { }
        public static dynamic headSpinIndex;
        public static void HolsterObject() { }
        public static void HolsterObject(params object[] args) { }
        public static void HoneycombSpam() { }
        public static void HoneycombSpam(params object[] args) { }
        public static void HookProjectileColors() { }
        public static void HookProjectileColors(params object[] args) { }
        public static void HoverboardAura() { }
        public static void HoverboardAura(params object[] args) { }
        public static void HoverboardGun() { }
        public static void HoverboardGun(params object[] args) { }
        public static void HoverboardScreenAll() { }
        public static void HoverboardScreenAll(params object[] args) { }
        public static void HoverboardScreenGun() { }
        public static void HoverboardScreenGun(params object[] args) { }
        public static void HoverboardScreenTarget() { }
        public static void HoverboardScreenTarget(params object[] args) { }
        public static void HoverboardSpam() { }
        public static void HoverboardSpam(params object[] args) { }
        public static void HueShift() { }
        public static void HueShift(params object[] args) { }
        public static void InstantParty() { }
        public static void InstantParty(params object[] args) { }
        public static void Invincibility() { }
        public static void Invincibility(params object[] args) { }
        public static void Jumpscare() { }
        public static void Jumpscare(params object[] args) { }
        public static void JumpscareOnTag() { }
        public static void JumpscareOnTag(params object[] args) { }
        public static void KeyboardTracker() { }
        public static void KeyboardTracker(params object[] args) { }
        public static void KillBees() { }
        public static void KillBees(params object[] args) { }
        public static void LaggyMicrophone() { }
        public static void LaggyMicrophone(params object[] args) { }
        public static void LavaSplashAura() { }
        public static void LavaSplashAura(params object[] args) { }
        public static void LavaSplashGun() { }
        public static void LavaSplashGun(params object[] args) { }
        public static void LavaSplashHands() { }
        public static void LavaSplashHands(params object[] args) { }
        public static void LoadBuilderTableData() { }
        public static void LoadBuilderTableData(params object[] args) { }
        public static void LongName() { }
        public static void LongName(params object[] args) { }
        public static void LoudHandTaps() { }
        public static void LoudHandTaps(params object[] args) { }
        public static void LowercaseName() { }
        public static void LowercaseName(params object[] args) { }
        public static void MaskVoice() { }
        public static void MaskVoice(params object[] args) { }
        public static void MassiveBlock() { }
        public static void MassiveBlock(params object[] args) { }
        public static void MaxQuestScore() { }
        public static void MaxQuestScore(params object[] args) { }
        public static void ModifyGliderSpeed() { }
        public static void ModifyGliderSpeed(params object[] args) { }
        public static void MonsterGun() { }
        public static void MonsterGun(params object[] args) { }
        public static void MultiGrab() { }
        public static void MultiGrab(params object[] args) { }
        public static void MuteAll() { }
        public static void MuteAll(params object[] args) { }
        public static void MuteDJSets() { }
        public static void MuteDJSets(params object[] args) { }
        public static void MuteGun() { }
        public static void MuteGun(params object[] args) { }
        public static void MuteMicrophone() { }
        public static void MuteMicrophone(params object[] args) { }
        public static dynamic name;
        public static void NameCycle() { }
        public static void NameCycle(params object[] args) { }
        public static dynamic nameCycleIndex;
        public static dynamic names;
        public static void NarrateCreationDateAll() { }
        public static void NarrateCreationDateAll(params object[] args) { }
        public static void NarrateCreationDateAura() { }
        public static void NarrateCreationDateAura(params object[] args) { }
        public static void NarrateCreationDateGun() { }
        public static void NarrateCreationDateGun(params object[] args) { }
        public static void NarrateCreationDateOnTouch() { }
        public static void NarrateCreationDateOnTouch(params object[] args) { }
        public static void NarrateCreationDateSelf() { }
        public static void NarrateCreationDateSelf(params object[] args) { }
        public static void NarrateFakeDoxxAll() { }
        public static void NarrateFakeDoxxAll(params object[] args) { }
        public static void NarrateFakeDoxxAura() { }
        public static void NarrateFakeDoxxAura(params object[] args) { }
        public static void NarrateFakeDoxxGun() { }
        public static void NarrateFakeDoxxGun(params object[] args) { }
        public static void NarrateFakeDoxxOnTouch() { }
        public static void NarrateFakeDoxxOnTouch(params object[] args) { }
        public static void NarrateFakeDoxxSelf() { }
        public static void NarrateFakeDoxxSelf(params object[] args) { }
        public static void NarrateIDAll() { }
        public static void NarrateIDAll(params object[] args) { }
        public static void NarrateIDAura() { }
        public static void NarrateIDAura(params object[] args) { }
        public static void NarrateIDGun() { }
        public static void NarrateIDGun(params object[] args) { }
        public static void NarrateIDOnTouch() { }
        public static void NarrateIDOnTouch(params object[] args) { }
        public static void NarrateSelfID() { }
        public static void NarrateSelfID(params object[] args) { }
        public static void Nausea() { }
        public static void Nausea(params object[] args) { }
        public static void NoAutoLoadCosmetics() { }
        public static void NoAutoLoadCosmetics(params object[] args) { }
        public static void NoclipBuilding() { }
        public static void NoclipBuilding(params object[] args) { }
        public static void ObjectAura() { }
        public static void ObjectAura(params object[] args) { }
        public static void ObjectToHand() { }
        public static void ObjectToHand(params object[] args) { }
        public static void ObjectToPointGun() { }
        public static void ObjectToPointGun(params object[] args) { }
        public static void OrbitBalloons() { }
        public static void OrbitBalloons(params object[] args) { }
        public static void OrbitBlocks() { }
        public static void OrbitBlocks(params object[] args) { }
        public static void OrbitCamera() { }
        public static void OrbitCamera(params object[] args) { }
        public static void OrbitGliders() { }
        public static void OrbitGliders(params object[] args) { }
        public static void OrbitHoverboards() { }
        public static void OrbitHoverboards(params object[] args) { }
        public static void OrbitMonsters() { }
        public static void OrbitMonsters(params object[] args) { }
        public static void OrbitObject() { }
        public static void OrbitObject(params object[] args) { }
        public static void OrbitTablet() { }
        public static void OrbitTablet(params object[] args) { }
        public static void OrbitWaterSplash() { }
        public static void OrbitWaterSplash(params object[] args) { }
        public static void PackCosmetics() { }
        public static void PackCosmetics(params object[] args) { }
        public static void PermanentOwnership() { }
        public static void PermanentOwnership(params object[] args) { }
        public static void PhysicalCamera() { }
        public static void PhysicalCamera(params object[] args) { }
        public static void PhysicalObject() { }
        public static void PhysicalObject(params object[] args) { }
        public static dynamic pieceId;
        public static void PieceNameHelper() { }
        public static void PieceNameHelper(params object[] args) { }
        public static void PlaceBlockGun() { }
        public static void PlaceBlockGun(params object[] args) { }
        public static void PopAllBalloons() { }
        public static void PopAllBalloons(params object[] args) { }
        public static void PreloadJumpscareData() { }
        public static void PreloadJumpscareData(params object[] args) { }
        public static void PreloadTagSounds() { }
        public static void PreloadTagSounds(params object[] args) { }
        public static void PrioritizeVoiceGun() { }
        public static void PrioritizeVoiceGun(params object[] args) { }
        public static void ProcessFrameBuffer() { }
        public static void ProcessFrameBuffer(params object[] args) { }
        public static void ProjectileRange() { }
        public static void ProjectileRange(params object[] args) { }
        public static dynamic projHookColor;
        public static void PurchaseAllToolStations() { }
        public static void PurchaseAllToolStations(params object[] args) { }
        public static void QuestNoises() { }
        public static void QuestNoises(params object[] args) { }
        public static void RainbowBracelet() { }
        public static void RainbowBracelet(params object[] args) { }
        public static void RainbowColor() { }
        public static void RainbowColor(params object[] args) { }
        public static void RainbowHoverboard() { }
        public static void RainbowHoverboard(params object[] args) { }
        public static void RainBuildingBlocks() { }
        public static void RainBuildingBlocks(params object[] args) { }
        public static void RandomHoverboard() { }
        public static void RandomHoverboard(params object[] args) { }
        public static void RandomNameCycle() { }
        public static void RandomNameCycle(params object[] args) { }
        public static void ReloadMicrophone() { }
        public static void ReloadMicrophone(params object[] args) { }
        public static void RemoveBracelet() { }
        public static void RemoveBracelet(params object[] args) { }
        public static void RemoveBuilderWatch() { }
        public static void RemoveBuilderWatch(params object[] args) { }
        public static void RemoveRainbowBracelet() { }
        public static void RemoveRainbowBracelet(params object[] args) { }
        public static void ReportAll() { }
        public static void ReportAll(params object[] args) { }
        public static void ReportGun() { }
        public static void ReportGun(params object[] args) { }
        public static void RequestCreatePiece() { }
        public static void RequestCreatePiece(params object[] args) { }
        public static void ResetVoiceAll() { }
        public static void ResetVoiceAll(params object[] args) { }
        public static void RespawnGliders() { }
        public static void RespawnGliders(params object[] args) { }
        public static void RideObject() { }
        public static void RideObject(params object[] args) { }
        public static void RopeGrabReach() { }
        public static void RopeGrabReach(params object[] args) { }
        public static void SaveBuilderTableData() { }
        public static void SaveBuilderTableData(params object[] args) { }
        public static void SaveNarration() { }
        public static void SaveNarration(params object[] args) { }
        public static void SelectBlockGun() { }
        public static void SelectBlockGun(params object[] args) { }
        public static void SetBasementDoorState() { }
        public static void SetBasementDoorState(params object[] args) { }
        public static void SetCurrencyAll() { }
        public static void SetCurrencyAll(params object[] args) { }
        public static void SetCurrencyGun() { }
        public static void SetCurrencyGun(params object[] args) { }
        public static void SetCurrencySelf() { }
        public static void SetCurrencySelf(params object[] args) { }
        public static void SetDebugEchoMode() { }
        public static void SetDebugEchoMode(params object[] args) { }
        public static void SetElevatorDoorState() { }
        public static void SetElevatorDoorState(params object[] args) { }
        public static void SetMicrophoneAmplification() { }
        public static void SetMicrophoneAmplification(params object[] args) { }
        public static void SetMicrophonePitch() { }
        public static void SetMicrophonePitch(params object[] args) { }
        public static void SetMicrophoneQuality() { }
        public static void SetMicrophoneQuality(params object[] args) { }
        public static void SetObjectSpeed() { }
        public static void SetObjectSpeed(params object[] args) { }
        public static void SetPropDistanceLimit() { }
        public static void SetPropDistanceLimit(params object[] args) { }
        public static void SetQuota() { }
        public static void SetQuota(params object[] args) { }
        public static void SetRespawnDistance() { }
        public static void SetRespawnDistance(params object[] args) { }
        public static void SetStateAll() { }
        public static void SetStateAll(params object[] args) { }
        public static void SetStateGun() { }
        public static void SetStateGun(params object[] args) { }
        public static void SetStateSelf() { }
        public static void SetStateSelf(params object[] args) { }
        public static void Shotgun() { }
        public static void Shotgun(params object[] args) { }
        public static void SidewaysHead() { }
        public static void SidewaysHead(params object[] args) { }
        public static void SilentHandTaps() { }
        public static void SilentHandTaps(params object[] args) { }
        public static void SilentHandTapsOnTag() { }
        public static void SilentHandTapsOnTag(params object[] args) { }
        public static void SlingshotHelper() { }
        public static void SlingshotHelper(params object[] args) { }
        public static void SlingshotSelf() { }
        public static void SlingshotSelf(params object[] args) { }
        public static void SlingshotTriggerBot() { }
        public static void SlingshotTriggerBot(params object[] args) { }
        public static void SlowHoverboard() { }
        public static void SlowHoverboard(params object[] args) { }
        public static void SlowMonsters() { }
        public static void SlowMonsters(params object[] args) { }
        public static void SlowSnowballs() { }
        public static void SlowSnowballs(params object[] args) { }
        public static void SlowTrain() { }
        public static void SlowTrain(params object[] args) { }
        public static void SnowballBreasts() { }
        public static void SnowballBreasts(params object[] args) { }
        public static void SnowballButtocks() { }
        public static void SnowballButtocks(params object[] args) { }
        public static void SpamGrabBlocks() { }
        public static void SpamGrabBlocks(params object[] args) { }
        public static void SpawnHoverboard() { }
        public static void SpawnHoverboard(params object[] args) { }
        public static void SpazAccessories() { }
        public static void SpazAccessories(params object[] args) { }
        public static void SpazAccessoriesBalloon() { }
        public static void SpazAccessoriesBalloon(params object[] args) { }
        public static void SpazAccessoriesOthers() { }
        public static void SpazAccessoriesOthers(params object[] args) { }
        public static void SpazBalloons() { }
        public static void SpazBalloons(params object[] args) { }
        public static void SpazCamera() { }
        public static void SpazCamera(params object[] args) { }
        public static void SpazGliders() { }
        public static void SpazGliders(params object[] args) { }
        public static void SpazHead() { }
        public static void SpazHead(params object[] args) { }
        public static void SpazHoldables() { }
        public static void SpazHoldables(params object[] args) { }
        public static void SpazHoverboard() { }
        public static void SpazHoverboard(params object[] args) { }
        public static void SpazKillAll() { }
        public static void SpazKillAll(params object[] args) { }
        public static void SpazKillGun() { }
        public static void SpazKillGun(params object[] args) { }
        public static void SpazKillSelf() { }
        public static void SpazKillSelf(params object[] args) { }
        public static void SpazMoleMachines() { }
        public static void SpazMoleMachines(params object[] args) { }
        public static void SpazMonsters() { }
        public static void SpazMonsters(params object[] args) { }
        public static void SpazObject() { }
        public static void SpazObject(params object[] args) { }
        public static void SpazSnowballs() { }
        public static void SpazSnowballs(params object[] args) { }
        public static void SpazTablet() { }
        public static void SpazTablet(params object[] args) { }
        public static void SpazToolStations() { }
        public static void SpazToolStations(params object[] args) { }
        public static void SpazVoice() { }
        public static void SpazVoice(params object[] args) { }
        public static void SpectateGun() { }
        public static void SpectateGun(params object[] args) { }
        public static void SpinHead() { }
        public static void SpinHead(params object[] args) { }
        public static dynamic splashDel;
        public static void StartAllRaces() { }
        public static void StartAllRaces(params object[] args) { }
        public static void StartShift() { }
        public static void StartShift(params object[] args) { }
        public static void StealBat() { }
        public static void StealBat(params object[] args) { }
        public static void StealBug() { }
        public static void StealBug(params object[] args) { }
        public static void StickyHoldables() { }
        public static void StickyHoldables(params object[] args) { }
        public static void StingAll() { }
        public static void StingAll(params object[] args) { }
        public static void StingGun() { }
        public static void StingGun(params object[] args) { }
        public static void StingSelf() { }
        public static void StingSelf(params object[] args) { }
        public static void StrobeColor() { }
        public static void StrobeColor(params object[] args) { }
        public static void StrobeHoverboard() { }
        public static void StrobeHoverboard(params object[] args) { }
        public static void StumpTeleporterEffectSpam() { }
        public static void StumpTeleporterEffectSpam(params object[] args) { }
        public static void TabletAura() { }
        public static void TabletAura(params object[] args) { }
        public static void TabletGun() { }
        public static void TabletGun(params object[] args) { }
        public static void TapAllClass() { }
        public static void TapAllClass(params object[] args) { }
        public static void TapAllClass<T>() { }
        public static void TapAllClass<T>(params object[] args) { }
        public static dynamic targetFOV;
        public static dynamic targetQuestScore;
        public static void ThirdPersonCamera() { }
        public static void ThirdPersonCamera(params object[] args) { }
        public static void ThrowableProjectileGun() { }
        public static void ThrowableProjectileGun(params object[] args) { }
        public static void ThrowableProjectileMinigun() { }
        public static void ThrowableProjectileMinigun(params object[] args) { }
        public static void ThrowableProjectileSpam() { }
        public static void ThrowableProjectileSpam(params object[] args) { }
        public static void TrainGun() { }
        public static void TrainGun(params object[] args) { }
        public static void TriggerAntiReportAll() { }
        public static void TriggerAntiReportAll(params object[] args) { }
        public static void TriggerAntiReportGun() { }
        public static void TriggerAntiReportGun(params object[] args) { }
        public static void TriggerLeafPileGun() { }
        public static void TriggerLeafPileGun(params object[] args) { }
        public static void TryOffAnywhere() { }
        public static void TryOffAnywhere(params object[] args) { }
        public static void TryOnAnywhere() { }
        public static void TryOnAnywhere(params object[] args) { }
        public static void UnacidAll() { }
        public static void UnacidAll(params object[] args) { }
        public static void UnacidGun() { }
        public static void UnacidGun(params object[] args) { }
        public static void UnacidSelf() { }
        public static void UnacidSelf(params object[] args) { }
        public static void UnlimitedBuilding() { }
        public static void UnlimitedBuilding(params object[] args) { }
        public static void UnlockAllCosmetics() { }
        public static void UnlockAllCosmetics(params object[] args) { }
        public static void UnmuteAll() { }
        public static void UnmuteAll(params object[] args) { }
        public static void UnmuteDJSets() { }
        public static void UnmuteDJSets(params object[] args) { }
        public static void UnspazVoice() { }
        public static void UnspazVoice(params object[] args) { }
        public static void UpsideDownHead() { }
        public static void UpsideDownHead(params object[] args) { }
        public static void WaterSplashAura() { }
        public static void WaterSplashAura(params object[] args) { }
        public static void WaterSplashGun() { }
        public static void WaterSplashGun(params object[] args) { }
        public static void WaterSplashHands() { }
        public static void WaterSplashHands(params object[] args) { }
        public static void WaterSplashWalk() { }
        public static void WaterSplashWalk(params object[] args) { }
        public static void WhiteColorGun() { }
        public static void WhiteColorGun(params object[] args) { }
        public static void WhiteColorTarget() { }
        public static void WhiteColorTarget(params object[] args) { }
    }

    public static class Important
    {
        public static void AcceptTOS() { }
        public static void AcceptTOS(params object[] args) { }
        public static void BlockOnMute() { }
        public static void BlockOnMute(params object[] args) { }
        public static void BroadcastRoom() { }
        public static void BroadcastRoom(params object[] args) { }
        public static void CancelReconnect() { }
        public static void CancelReconnect(params object[] args) { }
        public static void CapFPS() { }
        public static void CapFPS(params object[] args) { }
        public static void CheckNewAcc() { }
        public static void CheckNewAcc(params object[] args) { }
        public static void ConnectToRegion() { }
        public static void ConnectToRegion(params object[] args) { }
        public static void CopyPlayerPosition() { }
        public static void CopyPlayerPosition(params object[] args) { }
        public static void CreateRoom() { }
        public static void CreateRoom(params object[] args) { }
        public static void DisableDiscordRPC() { }
        public static void DisableDiscordRPC(params object[] args) { }
        public static void DisableFPC() { }
        public static void DisableFPC(params object[] args) { }
        public static void DisableMediaIntegration() { }
        public static void DisableMediaIntegration(params object[] args) { }
        public static void DisableMouthMovement() { }
        public static void DisableMouthMovement(params object[] args) { }
        public static void DisablePCButtonClick() { }
        public static void DisablePCButtonClick(params object[] args) { }
        public static void DisablePhysicalQuitbox() { }
        public static void DisablePhysicalQuitbox(params object[] args) { }
        public static void DisablePitchScaling() { }
        public static void DisablePitchScaling(params object[] args) { }
        public static void DiscordRPC() { }
        public static void DiscordRPC(params object[] args) { }
        public static void EnableFPC() { }
        public static void EnableFPC(params object[] args) { }
        public static void EnableMouthMovement() { }
        public static void EnableMouthMovement(params object[] args) { }
        public static void EnablePitchScaling() { }
        public static void EnablePitchScaling(params object[] args) { }
        public static void EnsureIntegrationProgram() { }
        public static void EnsureIntegrationProgram(params object[] args) { }
        public static void ForceEnableHands() { }
        public static void ForceEnableHands(params object[] args) { }
        public static dynamic instantCreate;
        public static void JoinDiscord() { }
        public static void JoinDiscord(params object[] args) { }
        public static void JoinRandom() { }
        public static void JoinRandom(params object[] args) { }
        public static void MediaIntegration() { }
        public static void MediaIntegration(params object[] args) { }
        public static void MoveFPC() { }
        public static void MoveFPC(params object[] args) { }
        public static void OculusReportMenu() { }
        public static void OculusReportMenu(params object[] args) { }
        public static dynamic oldId;
        public static void OpenGorillaTagFolder() { }
        public static void OpenGorillaTagFolder(params object[] args) { }
        public static void PCButtonClick() { }
        public static void PCButtonClick(params object[] args) { }
        public static void PCControllerEmulation() { }
        public static void PCControllerEmulation(params object[] args) { }
        public static void PhysicalQuitbox() { }
        public static void PhysicalQuitbox(params object[] args) { }
        public static dynamic queueCoroutine;
        public static void QueueRoom() { }
        public static void QueueRoom(params object[] args) { }
        public static string RandomRoomName() => string.Empty;
        public static string RandomRoomName(params object[] args) => string.Empty;
        public static void Reconnect() { }
        public static void Reconnect(params object[] args) { }
        public static float reconnectDelay = 1f;
        public static IEnumerator RedeemShinyRocks() { yield break; }
        public static IEnumerator RedeemShinyRocks(params object[] args) { yield break; }
        public static void RestartGame() { }
        public static void RestartGame(params object[] args) { }
        public static void SteamDetector() { }
        public static void SteamDetector(params object[] args) { }
        public static void TagLagDetector() { }
        public static void TagLagDetector(params object[] args) { }
        public static void UncapFPS() { }
        public static void UncapFPS(params object[] args) { }
    }

    public static class Movement
    {
        public static float _flySpeed = 10f;

        private static float CurrentFlySpeed => _flySpeed > 0f ? _flySpeed : 10f;

        private static void TranslateLocalPlayer(Vector3 delta)
        {
            if (delta == Vector3.zero)
                return;

            if (GTPlayer.Instance != null)
            {
                GTPlayer.Instance.transform.position += delta;
                return;
            }

            Rigidbody body = GorillaTagger.Instance?.rigidbody;
            if (body != null)
                body.transform.position += delta;
        }

        private static void StopLocalVelocity()
        {
            Rigidbody body = GorillaTagger.Instance?.rigidbody;
            if (body != null)
                body.linearVelocity = Vector3.zero;
        }
        public static void AdvancedCheckpoints() { }
        public static void AdvancedCheckpoints(params object[] args) { }
        public static void Airstrike() { }
        public static void Airstrike(params object[] args) { }
        public static void AirSwim() { }
        public static void AirSwim(params object[] args) { }
        public static void AlwaysMaxVelocity() { }
        public static void AlwaysMaxVelocity(params object[] args) { }
        public static void AmputateRig() { }
        public static void AmputateRig(params object[] args) { }
        public static void AnnoyAllPlayers() { }
        public static void AnnoyAllPlayers(params object[] args) { }
        public static void AnnoyPlayerGun() { }
        public static void AnnoyPlayerGun(params object[] args) { }
        public static void AutoBranch() { }
        public static void AutoBranch(params object[] args) { }
        public static void AutoDance() { }
        public static void AutoDance(params object[] args) { }
        public static void AutoElevatorClimb() { }
        public static void AutoElevatorClimb(params object[] args) { }
        public static void AutoFunnyRun() { }
        public static void AutoFunnyRun(params object[] args) { }
        public static void AutoGriddy() { }
        public static void AutoGriddy(params object[] args) { }
        public static void AutoPinchClimb() { }
        public static void AutoPinchClimb(params object[] args) { }
        public static void AutoTPose() { }
        public static void AutoTPose(params object[] args) { }
        public static void AutoWalk() { }
        public static void AutoWalk(params object[] args) { }
        public static void BarkFly()
        {
            if (GorillaTagger.Instance?.rigidbody == null || GTPlayer.Instance?.bodyCollider == null)
                return;

            Vector2 leftJoy = iiMenu.Menu.Main.leftJoystick;
            Vector2 rightJoy = iiMenu.Menu.Main.rightJoystick;
            Vector3 inputDirection = new Vector3(leftJoy.x, rightJoy.y, leftJoy.y);

            Vector3 playerForward = GTPlayer.Instance.bodyCollider.transform.forward;
            Vector3 playerRight = GTPlayer.Instance.bodyCollider.transform.right;
            playerForward.y = 0f;
            playerRight.y = 0f;

            if (playerForward.sqrMagnitude > 0f)
                playerForward.Normalize();
            if (playerRight.sqrMagnitude > 0f)
                playerRight.Normalize();

            Vector3 velocity = inputDirection.x * playerRight + inputDirection.y * Vector3.up + inputDirection.z * playerForward;
            velocity *= CurrentFlySpeed;

            GorillaTagger.Instance.rigidbody.linearVelocity =
                Vector3.Lerp(GorillaTagger.Instance.rigidbody.linearVelocity, velocity, 0.12875f);
        }
        public static void BarkFly(params object[] args) => BarkFly();
        public static void Bees() { }
        public static void Bees(params object[] args) { }
        public static void Beyblade() { }
        public static void Beyblade(params object[] args) { }
        private static float _birdFlapTime;
        private static Vector3 _birdLastLeftPos;
        private static Vector3 _birdLastRightPos;
        public static void BirdFly()
        {
            if (GorillaTagger.Instance?.rigidbody == null || GorillaTagger.Instance.leftHandTransform == null || GorillaTagger.Instance.rightHandTransform == null)
                return;

            Vector3 leftPos = GorillaTagger.Instance.leftHandTransform.position;
            Vector3 rightPos = GorillaTagger.Instance.rightHandTransform.position;

            if (_birdLastLeftPos == Vector3.zero)
                _birdLastLeftPos = leftPos;
            if (_birdLastRightPos == Vector3.zero)
                _birdLastRightPos = rightPos;

            float deltaTime = Mathf.Max(Time.deltaTime, 0.0001f);
            float leftVelY = (leftPos.y - _birdLastLeftPos.y) / deltaTime;
            float rightVelY = (rightPos.y - _birdLastRightPos.y) / deltaTime;

            _birdLastLeftPos = leftPos;
            _birdLastRightPos = rightPos;

            if (Time.time - _birdFlapTime < 0.2f)
                return;

            if (leftVelY < -1.0f && rightVelY < -1.0f)
            {
                float boost = Mathf.Clamp(CurrentFlySpeed * 0.5f, 3f, 10f);
                GorillaTagger.Instance.rigidbody.linearVelocity += Vector3.up * boost;
                _birdFlapTime = Time.time;
            }
        }
        public static void BirdFly(params object[] args) => BirdFly();
        public static void Blink() { }
        public static void Blink(params object[] args) { }
        public static void Bomb() { }
        public static void Bomb(params object[] args) { }
        public static dynamic bothWallWalk;
        public static void Bouncy() { }
        public static void Bouncy(params object[] args) { }
        public static void BunnyHop() { }
        public static void BunnyHop(params object[] args) { }
        public static void ChangeArmLength() { }
        public static void ChangeArmLength(params object[] args) { }
        public static void ChangeDriveSpeed() { }
        public static void ChangeDriveSpeed(params object[] args) { }
        public static void ChangeFakeLagStrength() { }
        public static void ChangeFakeLagStrength(params object[] args) { }
        public static void ChangeFastRopesSpeed() { }
        public static void ChangeFastRopesSpeed(params object[] args) { }
        public static void ChangeFlySpeed() => ChangeFlySpeed(true);
        public static void ChangeFlySpeed(bool positive = true)
        {
            float[] speedAmounts = { 5f, 10f, 30f, 60f, 0.5f };
            string[] speedNames = { "Slow", "Normal", "Fast", "Extra Fast", "Extra Slow" };

            if (positive)
                flySpeedCycle++;
            else
                flySpeedCycle--;

            flySpeedCycle %= speedAmounts.Length;
            if (flySpeedCycle < 0)
                flySpeedCycle = speedAmounts.Length - 1;

            _flySpeed = speedAmounts[flySpeedCycle];

            try
            {
                iiMenu.Menu.Buttons.GetIndex("Change Fly Speed").overlapText = "Change Fly Speed <color=grey>[</color><color=green>" + speedNames[flySpeedCycle] + "</color><color=grey>]</color>";
            }
            catch
            {
                // Ignore if the menu button index is not available yet.
            }
        }
        public static void ChangeFlySpeed(params object[] args)
        {
            bool positive = true;
            if (args != null && args.Length > 0 && args[0] is bool value)
                positive = value;

            ChangeFlySpeed(positive);
        }
        public static void ChangeMacroPlaybackRange() { }
        public static void ChangeMacroPlaybackRange(params object[] args) { }
        public static void ChangePlatformShape() { }
        public static void ChangePlatformShape(params object[] args) { }
        public static void ChangePlatformType() { }
        public static void ChangePlatformType(params object[] args) { }
        public static void ChangePlayspaceAbuseSpeed() { }
        public static void ChangePlayspaceAbuseSpeed(params object[] args) { }
        public static void ChangePredictionAmount() { }
        public static void ChangePredictionAmount(params object[] args) { }
        public static void ChangePullModPower() { }
        public static void ChangePullModPower(params object[] args) { }
        public static void ChangeSpeedBoostAmount() { }
        public static void ChangeSpeedBoostAmount(params object[] args) { }
        public static void ChangeTimerSpeed() { }
        public static void ChangeTimerSpeed(params object[] args) { }
        public static void ChangeTinnitusHz() { }
        public static void ChangeTinnitusHz(params object[] args) { }
        public static void ChangeWallWalkStrength() { }
        public static void ChangeWallWalkStrength(params object[] args) { }
        public static void Checkpoint() { }
        public static void Checkpoint(params object[] args) { }
        public static void ChickenRig() { }
        public static void ChickenRig(params object[] args) { }
        public static void ClearRewind() { }
        public static void ClearRewind(params object[] args) { }
        public static void ClimbyHands() { }
        public static void ClimbyHands(params object[] args) { }
        public static void ConfuseAllPlayers() { }
        public static void ConfuseAllPlayers(params object[] args) { }
        public static void ConfuseAllPlayersSplash() { }
        public static void ConfuseAllPlayersSplash(params object[] args) { }
        public static void ConfusePlayerGun() { }
        public static void ConfusePlayerGun(params object[] args) { }
        public static void ControllerFlick() { }
        public static void ControllerFlick(params object[] args) { }
        public static void CopyMovementAll() { }
        public static void CopyMovementAll(params object[] args) { }
        public static void CopyMovementGun() { }
        public static void CopyMovementGun(params object[] args) { }
        public static void CopyMovementPlayer() { }
        public static void CopyMovementPlayer(params object[] args) { }
        public static void CreateVelocityTrackers() { }
        public static void CreateVelocityTrackers(params object[] args) { }
        public static void Dash() { }
        public static void Dash(params object[] args) { }
        public static void DecapitateRigUpdate() { }
        public static void DecapitateRigUpdate(params object[] args) { }
        public static void DestroyEnderPearl() { }
        public static void DestroyEnderPearl(params object[] args) { }
        public static void DestroyVelocityTrackers() { }
        public static void DestroyVelocityTrackers(params object[] args) { }
        public static dynamic directionBased;
        public static void DisableAdvancedCheckpoints() { }
        public static void DisableAdvancedCheckpoints(params object[] args) { }
        public static void DisableAirSwim() { }
        public static void DisableAirSwim(params object[] args) { }
        public static void DisableBlink() { }
        public static void DisableBlink(params object[] args) { }
        public static void DisableBomb() { }
        public static void DisableBomb(params object[] args) { }
        public static void DisableCheckpoint() { }
        public static void DisableCheckpoint(params object[] args) { }
        public static void DisableClimbyHands() { }
        public static void DisableClimbyHands(params object[] args) { }
        public static void DisableControllerFlick() { }
        public static void DisableControllerFlick(params object[] args) { }
        public static void DisableFloatingRig() { }
        public static void DisableFloatingRig(params object[] args) { }
        public static void DisableGhostAnimations() { }
        public static void DisableGhostAnimations(params object[] args) { }
        public static dynamic disableMacros;
        public static void DisablePortalGun() { }
        public static void DisablePortalGun(params object[] args) { }
        public static void DisableSizeChanger() { }
        public static void DisableSizeChanger(params object[] args) { }
        public static void DisableSlideControl() { }
        public static void DisableSlideControl(params object[] args) { }
        public static void DisableSlipSlap() { }
        public static void DisableSlipSlap(params object[] args) { }
        public static void DisableSolidPlayers() { }
        public static void DisableSolidPlayers(params object[] args) { }
        public static void DisableSpazRig() { }
        public static void DisableSpazRig(params object[] args) { }
        public static void DisableSpiderMan() { }
        public static void DisableSpiderMan(params object[] args) { }
        public static void DisableSteamLongArms() { }
        public static void DisableSteamLongArms(params object[] args) { }
        public static void DisableStickyHands() { }
        public static void DisableStickyHands(params object[] args) { }
        public static void DisableTinnitus() { }
        public static void DisableTinnitus(params object[] args) { }
        public static void DisableVelocityCap() { }
        public static void DisableVelocityCap(params object[] args) { }
        public static void DisableWater() { }
        public static void DisableWater(params object[] args) { }
        public static void Drive() { }
        public static void Drive(params object[] args) { }
        public static dynamic driveInt;
        public static void DynamicSpeedBoost() { }
        public static void DynamicSpeedBoost(params object[] args) { }
        public static void DynamicStrafe() { }
        public static void DynamicStrafe(params object[] args) { }
        public static void EnableControllerFlick() { }
        public static void EnableControllerFlick(params object[] args) { }
        public static void EnableFloatingRig() { }
        public static void EnableFloatingRig(params object[] args) { }
        public static void EnableRig() { }
        public static void EnableRig(params object[] args) { }
        public static void EnableSlideControl() { }
        public static void EnableSlideControl(params object[] args) { }
        public static void EnableSpazHead() { }
        public static void EnableSpazHead(params object[] args) { }
        public static void EnableSpazRig() { }
        public static void EnableSpazRig(params object[] args) { }
        public static void EnableSteamLongArms() { }
        public static void EnableSteamLongArms(params object[] args) { }
        public static void EnableWeakSlideControl() { }
        public static void EnableWeakSlideControl(params object[] args) { }
        public static void EnderPearl() { }
        public static void EnderPearl(params object[] args) { }
        public static void EnterTeleportToMap() { }
        public static void EnterTeleportToMap(params object[] args) { }
        public static void Extenders() { }
        public static void Extenders(params object[] args) { }
        public static dynamic extendingTime;
        public static void EyeContact() { }
        public static void EyeContact(params object[] args) { }
        public static void FakeLag() { }
        public static void FakeLag(params object[] args) { }
        public static dynamic fakeLagDelayIndex;
        public static void Fan() { }
        public static void Fan(params object[] args) { }
        public static void FeatherFalling() { }
        public static void FeatherFalling(params object[] args) { }
        public static void FixBody() { }
        public static void FixBody(params object[] args) { }
        public static void FixHeadPosition() { }
        public static void FixHeadPosition(params object[] args) { }
        public static void FixWater() { }
        public static void FixWater(params object[] args) { }
        public static void FlickJump() { }
        public static void FlickJump(params object[] args) { }
        public static void FloatingRig() { }
        public static void FloatingRig(params object[] args) { }
        public static void Fly()
        {
            if (!iiMenu.Menu.Main.rightPrimary)
                return;

            if (GorillaTagger.Instance?.headCollider == null)
                return;

            TranslateLocalPlayer(GorillaTagger.Instance.headCollider.transform.forward * (Time.deltaTime * CurrentFlySpeed));
            StopLocalVelocity();
        }
        public static void Fly(params object[] args) => Fly();
        public static void FlySpeed() { }
        public static void FlySpeed(params object[] args) { }
        public static int flySpeedCycle = 1;
        public static void FlyTowardsGun()
        {
            if (!iiMenu.Menu.Main.GetGunInput(false))
            {
                if (iiMenu.Menu.Main.gunLocked)
                    iiMenu.Menu.Main.gunLocked = false;
                return;
            }

            var gunData = iiMenu.Menu.Main.RenderGun();
            if (iiMenu.Menu.Main.gunLocked && iiMenu.Menu.Main.lockTarget != null)
            {
                TranslateLocalPlayer((iiMenu.Menu.Main.lockTarget.transform.position - GorillaTagger.Instance.bodyCollider.transform.position) * (Time.deltaTime * CurrentFlySpeed));
                StopLocalVelocity();
            }

            if (!iiMenu.Menu.Main.GetGunInput(true))
                return;

            VRRig gunTarget = gunData.Ray.collider != null ? gunData.Ray.collider.GetComponentInParent<VRRig>() : null;
            if (gunTarget != null)
            {
                iiMenu.Menu.Main.gunLocked = true;
                iiMenu.Menu.Main.lockTarget = gunTarget;
            }
        }
        public static void FlyTowardsGun(params object[] args) => FlyTowardsGun();
        public static void FollowAllPlayers() { }
        public static void FollowAllPlayers(params object[] args) { }
        public static void FollowPlayer() { }
        public static void FollowPlayer(params object[] args) { }
        public static void FollowPlayerGun() { }
        public static void FollowPlayerGun(params object[] args) { }
        public static dynamic followPositions;
        public static void ForceTagFreeze() { }
        public static void ForceTagFreeze(params object[] args) { }
        public static string FormatMacroName() => string.Empty;
        public static string FormatMacroName(params object[] args) => args != null && args.Length > 0 ? args[0]?.ToString() ?? string.Empty : string.Empty;
        public static void ForwardsAndBackwards() { }
        public static void ForwardsAndBackwards(params object[] args) { }
        public static void FreezeBodyRotation() { }
        public static void FreezeBodyRotation(params object[] args) { }
        public static void FreezeRig() { }
        public static void FreezeRig(params object[] args) { }
        public static void FreezeRigBody() { }
        public static void FreezeRigBody(params object[] args) { }
        public static void FreezeRigLimbs() { }
        public static void FreezeRigLimbs(params object[] args) { }
        public static void Frozone() { }
        public static void Frozone(params object[] args) { }
        public static void FunMove() { }
        public static void FunMove(params object[] args) { }
        public static void Ghost() { }
        public static void Ghost(params object[] args) { }
        public static void GhostAnimations() { }
        public static void GhostAnimations(params object[] args) { }
        public static void GrabRig() { }
        public static void GrabRig(params object[] args) { }
        public static void GrapplingHooks() { }
        public static void GrapplingHooks(params object[] args) { }
        public static void GroundHelper() { }
        public static void GroundHelper(params object[] args) { }
        public static void HandFly()
        {
            if (!iiMenu.Menu.Main.rightPrimary)
                return;

            if (GorillaTagger.Instance?.rightHandTransform == null)
                return;

            TranslateLocalPlayer(GorillaTagger.Instance.rightHandTransform.forward * (Time.deltaTime * CurrentFlySpeed));
            StopLocalVelocity();
        }
        public static void HandFly(params object[] args) => HandFly();
        public static void HardDrive() { }
        public static void HardDrive(params object[] args) { }
        public static void HeadAll() { }
        public static void HeadAll(params object[] args) { }
        public static void HeadGun() { }
        public static void HeadGun(params object[] args) { }
        public static void Helicopter() { }
        public static void Helicopter(params object[] args) { }
        public static void HighGravity() { }
        public static void HighGravity(params object[] args) { }
        public static void HorizontalLongArms() { }
        public static void HorizontalLongArms(params object[] args) { }
        public static void IntercourseAll() { }
        public static void IntercourseAll(params object[] args) { }
        public static void IntercourseGun() { }
        public static void IntercourseGun(params object[] args) { }
        public static void IntercourseNoises() { }
        public static void IntercourseNoises(params object[] args) { }
        public static void Invisible() { }
        public static void Invisible(params object[] args) { }
        public static void IronMan() { }
        public static void IronMan(params object[] args) { }
        public static void JoystickFly()
        {
            if (GorillaTagger.Instance?.headCollider == null)
                return;

            Vector2 joy = iiMenu.Menu.Main.leftJoystick;
            if (Mathf.Abs(joy.x) <= 0.3f && Mathf.Abs(joy.y) <= 0.3f)
                return;

            Vector3 delta =
                GorillaTagger.Instance.headCollider.transform.forward * (Time.deltaTime * (joy.y * CurrentFlySpeed)) +
                GorillaTagger.Instance.headCollider.transform.right * (Time.deltaTime * (joy.x * CurrentFlySpeed));

            TranslateLocalPlayer(delta);
            StopLocalVelocity();
        }
        public static void JoystickFly(params object[] args) => JoystickFly();
        public static void JumpscareAll() { }
        public static void JumpscareAll(params object[] args) { }
        public static void JumpscareGun() { }
        public static void JumpscareGun(params object[] args) { }
        public static void LaggyRig() { }
        public static void LaggyRig(params object[] args) { }
        public static void LagRange() { }
        public static void LagRange(params object[] args) { }
        public static Vector3 lastPosition = Vector3.zero;
        public static void LeftAndRight() { }
        public static void LeftAndRight(params object[] args) { }
        public static dynamic leftWallWalk;
        public static void LegitimateWallWalk() { }
        public static void LegitimateWallWalk(params object[] args) { }
        public static void LoadMacros() { }
        public static void LoadMacros(params object[] args) { }
        public static dynamic longarmCycle;
        public static void LowGravity() { }
        public static void LowGravity(params object[] args) { }
        public struct Macro
        {
            public string name;
            public string DumpJSON() => string.Empty;
            public static Macro LoadJSON(string json) => default;
        }
        public static int macroPlaybackRangeIndex;
        public static Dictionary<string, Macro> macros = new Dictionary<string, Macro>();
        public static object[][] mapData = new object[][] { new object[] { null, null, null } };
        public static bool midpointMacros;
        public static void MinecraftAnimations() { }
        public static void MinecraftAnimations(params object[] args) { }
        public static int multiplicationAmount = 10;
        public static void MultiplicationAmount() { }
        public static void MultiplicationAmount(bool positive) { }
        public static void MultipliedLongArms() { }
        public static void MultipliedLongArms(params object[] args) { }
        public static void NetworkedGrappleMods() { }
        public static void NetworkedGrappleMods(params object[] args) { }
        public static void Noclip() { }
        public static void Noclip(params object[] args) { }
        public static void NoclipFly()
        {
            // Kept collision behavior neutral in compatibility mode; this guarantees fly movement works.
            Fly();
        }
        public static void NoclipFly(params object[] args) => NoclipFly();
        public static void NoTagFreeze() { }
        public static void NoTagFreeze(params object[] args) { }
        public static void OrbitAllPlayers() { }
        public static void OrbitAllPlayers(params object[] args) { }
        public static void OrbitPlayerGun() { }
        public static void OrbitPlayerGun(params object[] args) { }
        public static void OverstimulateAll() { }
        public static void OverstimulateAll(params object[] args) { }
        public static void OverstimulateGun() { }
        public static void OverstimulateGun(params object[] args) { }
        public static void ParalyzeRig() { }
        public static void ParalyzeRig(params object[] args) { }
        public static dynamic passWorldScaleCheck;
        public static void PiggybackAll() { }
        public static void PiggybackAll(params object[] args) { }
        public static void PiggybackGun() { }
        public static void PiggybackGun(params object[] args) { }
        public static void PlatformGun() { }
        public static void PlatformGun(params object[] args) { }
        public static dynamic platformMode;
        public static void Platforms() { }
        public static void Platforms(params object[] args) { }
        public static dynamic platformShape;
        public static void PlatformSpam() { }
        public static void PlatformSpam(params object[] args) { }
        public static dynamic playspace;
        public static void PlayspaceAbuse() { }
        public static void PlayspaceAbuse(params object[] args) { }
        public static dynamic playspaceAbuseIndex;
        public static void PortalGun() { }
        public static void PortalGun(params object[] args) { }
        public static void PostBouncy() { }
        public static void PostBouncy(params object[] args) { }
        public static void PreBouncy() { }
        public static void PreBouncy(params object[] args) { }
        public static dynamic predInt;
        public static void PullMod() { }
        public static void PullMod(params object[] args) { }
        public static dynamic pullPowerInt;
        public static void PunchMod() { }
        public static void PunchMod(params object[] args) { }
        public static void RandomSpazHead() { }
        public static void RandomSpazHead(params object[] args) { }
        public static void RandomSpazHeadPosition() { }
        public static void RandomSpazHeadPosition(params object[] args) { }
        public static dynamic recBodyRotary;
        public static void RecordMacro() { }
        public static void RecordMacro(params object[] args) { }
        public static void RecRoomBody() { }
        public static void RecRoomBody(params object[] args) { }
        public static void RemoveForestColliders() { }
        public static void RemoveForestColliders(params object[] args) { }
        public static void RestoreForestColliders() { }
        public static void RestoreForestColliders(params object[] args) { }
        public static void ReverseGravity() { }
        public static void ReverseGravity(params object[] args) { }
        public static void ReverseSchizoGun() { }
        public static void ReverseSchizoGun(params object[] args) { }
        public static void ReverseVelocity() { }
        public static void ReverseVelocity(params object[] args) { }
        public static void Rewind() { }
        public static void Rewind(params object[] args) { }
        public static void RigGun() { }
        public static void RigGun(params object[] args) { }
        public static void SafetyBubble() { }
        public static void SafetyBubble(params object[] args) { }
        public static void SchizophrenicGun() { }
        public static void SchizophrenicGun(params object[] args) { }
        public static void SetBodyPatch() { }
        public static void SetBodyPatch(params object[] args) { }
        public static void SetHandEnabled() { }
        public static void SetHandEnabled(params object[] args) { }
        public static void SetSwimSpeed() { }
        public static void SetSwimSpeed(params object[] args) { }
        public static void ShutdownHeadsetAll() { }
        public static void ShutdownHeadsetAll(params object[] args) { }
        public static void ShutdownHeadsetGun() { }
        public static void ShutdownHeadsetGun(params object[] args) { }
        public static void SizeChanger() { }
        public static void SizeChanger(params object[] args) { }
        public static void SlingshotFly()
        {
            if (!iiMenu.Menu.Main.rightPrimary)
                return;

            if (GTPlayer.Instance?.headCollider == null || GorillaTagger.Instance?.rigidbody == null)
                return;

            GorillaTagger.Instance.rigidbody.linearVelocity +=
                GTPlayer.Instance.headCollider.transform.forward * (Time.deltaTime * (CurrentFlySpeed * 2f));
        }
        public static void SlingshotFly(params object[] args) => SlingshotFly();
        public static void SlipSlap() { }
        public static void SlipSlap(params object[] args) { }
        public static void SolidPlayers() { }
        public static void SolidPlayers(params object[] args) { }
        public static void SolidWater() { }
        public static void SolidWater(params object[] args) { }
        public static void SpazHands() { }
        public static void SpazHands(params object[] args) { }
        public static void SpazHead() { }
        public static void SpazHead(params object[] args) { }
        public static void SpazHeadPosition() { }
        public static void SpazHeadPosition(params object[] args) { }
        public static void SpazRealHands() { }
        public static void SpazRealHands(params object[] args) { }
        public static void SpazRig() { }
        public static void SpazRig(params object[] args) { }
        public static void SpeedBoost() { }
        public static void SpeedBoost(params object[] args) { }
        public static dynamic speedboostCycle;
        public static void SpiderMan() { }
        public static void SpiderMan(params object[] args) { }
        public static void SpiderWalk() { }
        public static void SpiderWalk(params object[] args) { }
        public static void StareAtAll() { }
        public static void StareAtAll(params object[] args) { }
        public static void StareAtGun() { }
        public static void StareAtGun(params object[] args) { }
        public static void StareAtNearby() { }
        public static void StareAtNearby(params object[] args) { }
        public static void StareAtTarget() { }
        public static void StareAtTarget(params object[] args) { }
        public static dynamic startPosition;
        public static void StickLongArms() { }
        public static void StickLongArms(params object[] args) { }
        public static void StickyHands() { }
        public static void StickyHands(params object[] args) { }
        public static void StillBeyblade() { }
        public static void StillBeyblade(params object[] args) { }
        public static dynamic stillBeybladeStartPos;
        public static void Strafe() { }
        public static void Strafe(params object[] args) { }
        public static dynamic targetHz;
        public static void Telekinesis() { }
        public static void Telekinesis(params object[] args) { }
        public static void TeleportGun() { }
        public static void TeleportGun(params object[] args) { }
        public static IEnumerator TeleportObject() { yield break; }
        public static IEnumerator TeleportObject(params object[] args) { yield break; }
        public static IEnumerator TeleportPortal() { yield break; }
        public static IEnumerator TeleportPortal(params object[] args) { yield break; }
        public static void TeleportToMap() { }
        public static void TeleportToMap(params object[] args) { }
        public static void TeleportToPlayer() { }
        public static void TeleportToPlayer(params object[] args) { }
        public static void TeleportToRandom() { }
        public static void TeleportToRandom(params object[] args) { }
        public static void ThrowControllers() { }
        public static void ThrowControllers(params object[] args) { }
        public static void Timer() { }
        public static void Timer(params object[] args) { }
        public static dynamic timerPowerIndex;
        public static void TinnitusAll() { }
        public static void TinnitusAll(params object[] args) { }
        public static void TinnitusGun() { }
        public static void TinnitusGun(params object[] args) { }
        public static dynamic tinnitusSelf;
        public static void TorsoPatch_VRRigLateUpdate() { }
        public static void TorsoPatch_VRRigLateUpdate(params object[] args) { }
        public static void TriggerFly()
        {
            if (iiMenu.Menu.Main.rightTrigger <= 0.5f)
                return;

            if (GorillaTagger.Instance?.headCollider == null)
                return;

            TranslateLocalPlayer(GorillaTagger.Instance.headCollider.transform.forward * (Time.deltaTime * CurrentFlySpeed));
            StopLocalVelocity();
        }
        public static void TriggerFly(params object[] args) => TriggerFly();
        public static void UnflipCharacter() { }
        public static void UnflipCharacter(params object[] args) { }
        public static void UpAndDown() { }
        public static void UpAndDown(params object[] args) { }
        public static void UpdateRig() { }
        public static void UpdateRig(params object[] args) { }
        public static void VelocityBarkFly()
        {
            Vector2 leftJoy = iiMenu.Menu.Main.leftJoystick;
            Vector2 rightJoy = iiMenu.Menu.Main.rightJoystick;
            if (Mathf.Abs(leftJoy.x) > 0.3f || Mathf.Abs(leftJoy.y) > 0.3f || Mathf.Abs(rightJoy.x) > 0.3f || Mathf.Abs(rightJoy.y) > 0.3f)
                BarkFly();
        }
        public static void VelocityBarkFly(params object[] args) => VelocityBarkFly();
        public static void VelocityLongArms() { }
        public static void VelocityLongArms(params object[] args) { }
        public static void VerticalLongArms() { }
        public static void VerticalLongArms(params object[] args) { }
        public static void WallWalk() { }
        public static void WallWalk(params object[] args) { }
        public static dynamic wallWalkStrengthIndex;
        public static void WASDFly()
        {
            if (GorillaTagger.Instance?.headCollider == null)
                return;

            bool w = UnityInput.Current.GetKey(KeyCode.W);
            bool a = UnityInput.Current.GetKey(KeyCode.A);
            bool s = UnityInput.Current.GetKey(KeyCode.S);
            bool d = UnityInput.Current.GetKey(KeyCode.D);
            bool space = UnityInput.Current.GetKey(KeyCode.Space);
            bool ctrl = UnityInput.Current.GetKey(KeyCode.LeftControl);
            bool shift = UnityInput.Current.GetKey(KeyCode.LeftShift);
            bool alt = UnityInput.Current.GetKey(KeyCode.LeftAlt);

            bool stationary = true;
            try
            {
                stationary = !iiMenu.Menu.Buttons.GetIndex("Disable Stationary WASD Fly").enabled;
            }
            catch
            {
                // Ignore if the button index is not available.
            }

            bool anyMove = w || a || s || d || space || ctrl;
            bool lookingWithMouse = UnityInput.Current.GetKey(KeyCode.Mouse1);
            if (stationary || anyMove)
                StopLocalVelocity();

            float speed = CurrentFlySpeed;
            if (shift)
                speed *= 2f;
            else if (alt)
                speed /= 2f;

            Vector3 forward = GorillaTagger.Instance.headCollider.transform.forward;
            Vector3 right = GorillaTagger.Instance.headCollider.transform.right;
            forward.y = 0f;
            right.y = 0f;
            if (forward.sqrMagnitude > 0f)
                forward.Normalize();
            if (right.sqrMagnitude > 0f)
                right.Normalize();

            Vector3 move = Vector3.zero;
            if (w) move += forward;
            if (s) move -= forward;
            if (a) move -= right;
            if (d) move += right;
            if (space) move += Vector3.up;
            if (ctrl) move -= Vector3.up;

            if (move != Vector3.zero)
                TranslateLocalPlayer(move * (Time.deltaTime * speed));

            Rigidbody body = GorillaTagger.Instance?.rigidbody;
            bool shouldHoldPosition = stationary && !anyMove && !lookingWithMouse;
            if (shouldHoldPosition && lastPosition != Vector3.zero && body != null)
                body.transform.position = lastPosition;
            else if (body != null)
                lastPosition = body.transform.position;
        }
        public static void WASDFly(params object[] args) => WASDFly();
        public static void WaterRunHelper() { }
        public static void WaterRunHelper(params object[] args) { }
        public static void ZeroGravity() { }
        public static void ZeroGravity(params object[] args) { }
        public static void ZeroGravitySlingshotFly()
        {
            if (!iiMenu.Menu.Main.rightPrimary)
                return;

            if (GTPlayer.Instance?.headCollider == null || GorillaTagger.Instance?.rigidbody == null)
                return;

            Rigidbody body = GorillaTagger.Instance.rigidbody;
            body.linearVelocity += GTPlayer.Instance.headCollider.transform.forward * (Time.deltaTime * CurrentFlySpeed);
            body.linearVelocity = new Vector3(body.linearVelocity.x, Mathf.Max(body.linearVelocity.y, -0.2f), body.linearVelocity.z);
        }
        public static void ZeroGravitySlingshotFly(params object[] args) => ZeroGravitySlingshotFly();
    }

    public static class Overpowered
    {
        public static void AcidAll() { }
        public static void AcidAll(params object[] args) { }
        public static void AcidGun() { }
        public static void AcidGun(params object[] args) { }
        public static void AcidSelf() { }
        public static void AcidSelf(params object[] args) { }
        public static void ActivateGreyZone() { }
        public static void ActivateGreyZone(params object[] args) { }
        public static void ActivateGreyZoneGun() { }
        public static void ActivateGreyZoneGun(params object[] args) { }
        public static void Advertisement() { }
        public static void Advertisement(params object[] args) { }
        public static void AlwaysGuardian() { }
        public static void AlwaysGuardian(params object[] args) { }
        public static void AnnoyingLucy() { }
        public static void AnnoyingLucy(params object[] args) { }
        public static void AnnoyingLurker() { }
        public static void AnnoyingLurker(params object[] args) { }
        public static void AntiBan() { }
        public static void AntiBan(params object[] args) { }
        public static void AntiBanCheck() { }
        public static void AntiBanCheck(params object[] args) { }
        public static void AntiReportFling() { }
        public static void AntiReportFling(params object[] args) { }
        public static void AntiReportKick() { }
        public static void AntiReportKick(params object[] args) { }
        public static void AntiReportLag() { }
        public static void AntiReportLag(params object[] args) { }
        public static void AntiReportSnowballFling() { }
        public static void AntiReportSnowballFling(params object[] args) { }
        public static void AntiStump() { }
        public static void AntiStump(params object[] args) { }
        public static void AtticServersidedBlocks() { }
        public static void AtticServersidedBlocks(params object[] args) { }
        public static void AutoPartyBan() { }
        public static void AutoPartyBan(params object[] args) { }
        public static void AutoPartyKick() { }
        public static void AutoPartyKick(params object[] args) { }
        public static void AutoRepairKick() { }
        public static void AutoRepairKick(params object[] args) { }
        public static void BanAllInParty() { }
        public static void BanAllInParty(params object[] args) { }
        public static void BarrelCrashAll() { }
        public static void BarrelCrashAll(params object[] args) { }
        public static void BarrelCrashGun() { }
        public static void BarrelCrashGun(params object[] args) { }
        public static void BarrelFlingAll() { }
        public static void BarrelFlingAll(params object[] args) { }
        public static void BarrelFlingGun() { }
        public static void BarrelFlingGun(params object[] args) { }
        public static void BarrelFlingTowardsAll() { }
        public static void BarrelFlingTowardsAll(params object[] args) { }
        public static void BarrelFlingTowardsGun() { }
        public static void BarrelFlingTowardsGun(params object[] args) { }
        public const int BarrelIndex = 618;
        public static void BarrelKickAll() { }
        public static void BarrelKickAll(params object[] args) { }
        public static void BarrelKickGun() { }
        public static void BarrelKickGun(params object[] args) { }
        public static void BarrelPunchMod() { }
        public static void BarrelPunchMod(params object[] args) { }
        public static dynamic basePosition;
        public static void BecomeFirecrackers() { }
        public static void BecomeFirecrackers(params object[] args) { }
        public static void BecomeLucy() { }
        public static void BecomeLucy(params object[] args) { }
        public static void BecomeLurker() { }
        public static void BecomeLurker(params object[] args) { }
        public static void BetaSetStatus() { }
        public static void BetaSetStatus(params object[] args) { }
        public static void BetaSpawnSnowball() { }
        public static void BetaSpawnSnowball(params object[] args) { }
        public static void BigEmoji() { }
        public static void BigEmoji(params object[] args) { }
        public static void BlackScreenAll() { }
        public static void BlackScreenAll(params object[] args) { }
        public static void BlasterControlGun() { }
        public static void BlasterControlGun(params object[] args) { }
        public static void BlasterCrashAll() { }
        public static void BlasterCrashAll(params object[] args) { }
        public static void BlasterCrashGun() { }
        public static void BlasterCrashGun(params object[] args) { }
        public static void BlasterFlingAll() { }
        public static void BlasterFlingAll(params object[] args) { }
        public static void BlasterFlingAwayAll() { }
        public static void BlasterFlingAwayAll(params object[] args) { }
        public static void BlasterFlingAwayGun() { }
        public static void BlasterFlingAwayGun(params object[] args) { }
        public static void BlasterFlingGun() { }
        public static void BlasterFlingGun(params object[] args) { }
        public static void BlasterFlingTowardsAll() { }
        public static void BlasterFlingTowardsAll(params object[] args) { }
        public static void BlasterFlingTowardsGun() { }
        public static void BlasterFlingTowardsGun(params object[] args) { }
        public static void BlasterKickAll() { }
        public static void BlasterKickAll(params object[] args) { }
        public static void BlasterKickGun() { }
        public static void BlasterKickGun(params object[] args) { }
        public static void BlasterLaserSpam() { }
        public static void BlasterLaserSpam(params object[] args) { }
        public static void BlockCrashAll() { }
        public static void BlockCrashAll(params object[] args) { }
        public static void BlockCrashGun() { }
        public static void BlockCrashGun(params object[] args) { }
        public static void Boxing() { }
        public static void Boxing(params object[] args) { }
        public static void BreakAudioAll() { }
        public static void BreakAudioAll(params object[] args) { }
        public static void BreakAudioGun() { }
        public static void BreakAudioGun(params object[] args) { }
        public static void BreakLurker() { }
        public static void BreakLurker(params object[] args) { }
        public static void BringAll() { }
        public static void BringAll(params object[] args) { }
        public static void BringAllGun() { }
        public static void BringAllGun(params object[] args) { }
        public static void BringAwayAll() { }
        public static void BringAwayAll(params object[] args) { }
        public static void BringAwayAllGun() { }
        public static void BringAwayAllGun(params object[] args) { }
        public static void BringAwayGun() { }
        public static void BringAwayGun(params object[] args) { }
        public static void BringGun() { }
        public static void BringGun(params object[] args) { }
        public static void BringPlayer() { }
        public static void BringPlayer(params object[] args) { }
        public static void BringPlayerGun() { }
        public static void BringPlayerGun(params object[] args) { }
        public static void BubbleAll() { }
        public static void BubbleAll(params object[] args) { }
        public static void BubbleGun() { }
        public static void BubbleGun(params object[] args) { }
        public static void CacheKickAll() { }
        public static void CacheKickAll(params object[] args) { }
        public static void CacheKickGun() { }
        public static void CacheKickGun(params object[] args) { }
        public static void CasualGamemode() { }
        public static void CasualGamemode(params object[] args) { }
        public static void ChangeFriendStationPosition() { }
        public static void ChangeFriendStationPosition(params object[] args) { }
        public static void ChangeGamemode() { }
        public static void ChangeGamemode(params object[] args) { }
        public static void ChangeLagPower() { }
        public static void ChangeLagPower(params object[] args) { }
        public static void ChangeLagType() { }
        public static void ChangeLagType(params object[] args) { }
        public static void ChangeSnowballMultiplicationFactor() { }
        public static void ChangeSnowballMultiplicationFactor(params object[] args) { }
        public static void ChangeSnowballScale() { }
        public static void ChangeSnowballScale(params object[] args) { }
        public static dynamic characterIndex;
        public static void CityKickAll() { }
        public static void CityKickAll(params object[] args) { }
        public static void CityKickGun() { }
        public static void CityKickGun(params object[] args) { }
        public static void ClaimAllTerminals() { }
        public static void ClaimAllTerminals(params object[] args) { }
        public static void CloseRoom() { }
        public static void CloseRoom(params object[] args) { }
        public static void CompleteAllQuests() { }
        public static void CompleteAllQuests(params object[] args) { }
        public static void CrashAll() { }
        public static void CrashAll(params object[] args) { }
        public static void CrashGun() { }
        public static void CrashGun(params object[] args) { }
        public static void CrashPlayer() { }
        public static void CrashPlayer(params object[] args) { }
        public static void CreateItem() { }
        public static void CreateItem(params object[] args) { }
        public static void CreatePeerBase() { }
        public static void CreatePeerBase(params object[] args) { }
        public static void CritterGun() { }
        public static void CritterGun(params object[] args) { }
        public static void CritterMinigun() { }
        public static void CritterMinigun(params object[] args) { }
        public static void CritterSpam() { }
        public static void CritterSpam(params object[] args) { }
        public static void DeafenAll() { }
        public static void DeafenAll(params object[] args) { }
        public static void DeafenGun() { }
        public static void DeafenGun(params object[] args) { }
        public static void DebugBlasterAimbot() { }
        public static void DebugBlasterAimbot(params object[] args) { }
        public static void DelayBanAll() { }
        public static void DelayBanAll(params object[] args) { }
        public static void DelayBanGun() { }
        public static void DelayBanGun(params object[] args) { }
        public static void DespawnLucy() { }
        public static void DespawnLucy(params object[] args) { }
        public static void DespawnLurker() { }
        public static void DespawnLurker(params object[] args) { }
        public static void DestroyAll() { }
        public static void DestroyAll(params object[] args) { }
        public static void DestroyAura() { }
        public static void DestroyAura(params object[] args) { }
        public static void DestroyEntityGun() { }
        public static void DestroyEntityGun(params object[] args) { }
        public static void DestroyGadgetGun() { }
        public static void DestroyGadgetGun(params object[] args) { }
        public static void DestroyGun() { }
        public static void DestroyGun(params object[] args) { }
        public static void DestroyOnTouch() { }
        public static void DestroyOnTouch(params object[] args) { }
        public static void DestroyPlayer() { }
        public static void DestroyPlayer(params object[] args) { }
        public static void DirectionOnGrab() { }
        public static void DirectionOnGrab(params object[] args) { }
        public static void Disable_Kamehameha() { }
        public static void Disable_Kamehameha(params object[] args) { }
        public static void DisableBomb() { }
        public static void DisableBomb(params object[] args) { }
        public static dynamic DisableCoroutine;
        public static void DisableLeaderboardKick() { }
        public static void DisableLeaderboardKick(params object[] args) { }
        public static void DisableSnowball() { }
        public static void DisableSnowball(params object[] args) { }
        public static void DisableSnowballFlingZone() { }
        public static void DisableSnowballFlingZone(params object[] args) { }
        public static void DisableSnowballImpactEffect() { }
        public static void DisableSnowballImpactEffect(params object[] args) { }
        public static void DisableSnowballPositionalFountain() { }
        public static void DisableSnowballPositionalFountain(params object[] args) { }
        public static void DisableTowardsPointOnGrab() { }
        public static void DisableTowardsPointOnGrab(params object[] args) { }
        public static void DriverStatus() { }
        public static void DriverStatus(params object[] args) { }
        public static void DriverStatusGun() { }
        public static void DriverStatusGun(params object[] args) { }
        public static void EffectGun() { }
        public static void EffectGun(params object[] args) { }
        public static void EffectSpam() { }
        public static void EffectSpam(params object[] args) { }
        public static void EffectSpamGun() { }
        public static void EffectSpamGun(params object[] args) { }
        public static void EffectSpamHands() { }
        public static void EffectSpamHands(params object[] args) { }
        public static void ElevatorKickAll() { }
        public static void ElevatorKickAll(params object[] args) { }
        public static void ElevatorKickAura() { }
        public static void ElevatorKickAura(params object[] args) { }
        public static void ElevatorKickGun() { }
        public static void ElevatorKickGun(params object[] args) { }
        public static void ElevatorKickOnTouch() { }
        public static void ElevatorKickOnTouch(params object[] args) { }
        public static void Enable_Kamehameha() { }
        public static void Enable_Kamehameha(params object[] args) { }
        public static void EnableCacheKickAll() { }
        public static void EnableCacheKickAll(params object[] args) { }
        public static void EndMoonEvent() { }
        public static void EndMoonEvent(params object[] args) { }
        public static void EntityAura() { }
        public static void EntityAura(params object[] args) { }
        public static void EntityFountain() { }
        public static void EntityFountain(params object[] args) { }
        public static void FastLucy() { }
        public static void FastLucy(params object[] args) { }
        public static void FastMaster() { }
        public static void FastMaster(params object[] args) { }
        public static void FirecrackerAirstrikeGun() { }
        public static void FirecrackerAirstrikeGun(params object[] args) { }
        public static void FirecrackerCrashAll() { }
        public static void FirecrackerCrashAll(params object[] args) { }
        public static void FirecrackerCrashGun() { }
        public static void FirecrackerCrashGun(params object[] args) { }
        public static void FirecrackerFountain() { }
        public static void FirecrackerFountain(params object[] args) { }
        public static void FirecrackerGun() { }
        public static void FirecrackerGun(params object[] args) { }
        public static void FirecrackerInstantCrashAll() { }
        public static void FirecrackerInstantCrashAll(params object[] args) { }
        public static void FirecrackerInstantCrashGun() { }
        public static void FirecrackerInstantCrashGun(params object[] args) { }
        public static void FirecrackerRain() { }
        public static void FirecrackerRain(params object[] args) { }
        public static void FirecrackerSpam() { }
        public static void FirecrackerSpam(params object[] args) { }
        public static void FirecrackerSpray() { }
        public static void FirecrackerSpray(params object[] args) { }
        public static void FixThreshold() { }
        public static void FixThreshold(params object[] args) { }
        public static void FlashScreen() { }
        public static void FlashScreen(params object[] args) { }
        public static void FlingAll() { }
        public static void FlingAll(params object[] args) { }
        public static void FlingAllRopesGun() { }
        public static void FlingAllRopesGun(params object[] args) { }
        public static void FlingGun() { }
        public static void FlingGun(params object[] args) { }
        public static void FlingOnGrab() { }
        public static void FlingOnGrab(params object[] args) { }
        public static void FlingPlayer() { }
        public static void FlingPlayer(params object[] args) { }
        public static void FlingRopeGun() { }
        public static void FlingRopeGun(params object[] args) { }
        public static void ForceDrainLava() { }
        public static void ForceDrainLava(params object[] args) { }
        public static void ForceEruptLava() { }
        public static void ForceEruptLava(params object[] args) { }
        public static void ForceGrab() { }
        public static void ForceGrab(params object[] args) { }
        public static void ForceRiseLava() { }
        public static void ForceRiseLava(params object[] args) { }
        public static void ForceUneruptLava() { }
        public static void ForceUneruptLava(params object[] args) { }
        public static void ForceUnloadCustomMap() { }
        public static void ForceUnloadCustomMap(params object[] args) { }
        public static void FreezeServer() { }
        public static void FreezeServer(params object[] args) { }
        public static void GadgetAura() { }
        public static void GadgetAura(params object[] args) { }
        public static Dictionary<string, int> GadgetByName = new Dictionary<string, int>();
        public static void GadgetFountain() { }
        public static void GadgetFountain(params object[] args) { }
        public static void GadgetSpamGrip() { }
        public static void GadgetSpamGrip(params object[] args) { }
        public static void GadgetSpamGun() { }
        public static void GadgetSpamGun(params object[] args) { }
        public static void GetProjectileIncrement() { }
        public static void GetProjectileIncrement(params object[] args) { }
        public static void GhostReactorCrashAll() { }
        public static void GhostReactorCrashAll(params object[] args) { }
        public static void GhostReactorCrashGun() { }
        public static void GhostReactorCrashGun(params object[] args) { }
        public static void GhostReactorDrawGun() { }
        public static void GhostReactorDrawGun(params object[] args) { }
        public static void GhostReactorTextGun() { }
        public static void GhostReactorTextGun(params object[] args) { }
        public static void GiveFlyAll() { }
        public static void GiveFlyAll(params object[] args) { }
        public static void GiveFlyGun() { }
        public static void GiveFlyGun(params object[] args) { }
        public static void GiveSnowballMinigun() { }
        public static void GiveSnowballMinigun(params object[] args) { }
        public static void GliderBlindAll() { }
        public static void GliderBlindAll(params object[] args) { }
        public static void GliderBlindGun() { }
        public static void GliderBlindGun(params object[] args) { }
        public static void GrabAll() { }
        public static void GrabAll(params object[] args) { }
        public static void GrabGun() { }
        public static void GrabGun(params object[] args) { }
        public static void GuardianAll() { }
        public static void GuardianAll(params object[] args) { }
        public static void GuardianCrashAll() { }
        public static void GuardianCrashAll(params object[] args) { }
        public static void GuardianCrashGun() { }
        public static void GuardianCrashGun(params object[] args) { }
        public static void GuardianGun() { }
        public static void GuardianGun(params object[] args) { }
        public static void GuardianKickAll() { }
        public static void GuardianKickAll(params object[] args) { }
        public static void GuardianKickGun() { }
        public static void GuardianKickGun(params object[] args) { }
        public static void GuardianKickTarget() { }
        public static void GuardianKickTarget(params object[] args) { }
        public static void GuardianProtector() { }
        public static void GuardianProtector(params object[] args) { }
        public static void GuardianSelf() { }
        public static void GuardianSelf(params object[] args) { }
        public static void GuardianSpaz() { }
        public static void GuardianSpaz(params object[] args) { }
        public static void HuntGamemode() { }
        public static void HuntGamemode(params object[] args) { }
        public static void InfectionGamemode() { }
        public static void InfectionGamemode(params object[] args) { }
        public static void InfectionToTag() { }
        public static void InfectionToTag(params object[] args) { }
        public static void InfiniteResources() { }
        public static void InfiniteResources(params object[] args) { }
        public static void InstantCrashAll() { }
        public static void InstantCrashAll(params object[] args) { }
        public static void InstantCrashGun() { }
        public static void InstantCrashGun(params object[] args) { }
        public static dynamic InvisibleSnowballs;
        public static void JoystickRopeControl() { }
        public static void JoystickRopeControl(params object[] args) { }
        public static void Kamehameha() { }
        public static void Kamehameha(params object[] args) { }
        public static IEnumerator KickAll() { yield break; }
        public static IEnumerator KickAll(params object[] args) { yield break; }
        public static void KickAllInParty() { }
        public static void KickAllInParty(params object[] args) { }
        public static UnityEngine.Coroutine kickCoroutine;
        public static void KickGun() { }
        public static void KickGun(params object[] args) { }
        public static IEnumerator KickMasterClient() { yield break; }
        public static IEnumerator KickMasterClient(params object[] args) { yield break; }
        public static dynamic kickToPublic;
        public static void LagAll() { }
        public static void LagAll(params object[] args) { }
        public static void LagAura() { }
        public static void LagAura(params object[] args) { }
        public static void LagGun() { }
        public static void LagGun(params object[] args) { }
        public static dynamic lagIndex;
        public static void LagMasterClient() { }
        public static void LagMasterClient(params object[] args) { }
        public static void LagMasterClientGun() { }
        public static void LagMasterClientGun(params object[] args) { }
        public static void LagOnTouch() { }
        public static void LagOnTouch(params object[] args) { }
        public static void LagSpikeAll() { }
        public static void LagSpikeAll(params object[] args) { }
        public static void LagSpikeGun() { }
        public static void LagSpikeGun(params object[] args) { }
        public static void LagTarget() { }
        public static void LagTarget(params object[] args) { }
        public static dynamic lagTypeIndex;
        public static void LeaderboardKick() { }
        public static void LeaderboardKick(params object[] args) { }
        public static dynamic legacyKickFreeze;
        public static void Letters() { }
        public static void Letters(params object[] args) { }
        public static void LucyAttack() { }
        public static void LucyAttack(params object[] args) { }
        public static void LucyAttackAll() { }
        public static void LucyAttackAll(params object[] args) { }
        public static void LucyAttackGun() { }
        public static void LucyAttackGun(params object[] args) { }
        public static void LucyAttackSelf() { }
        public static void LucyAttackSelf(params object[] args) { }
        public static void LucyChase() { }
        public static void LucyChase(params object[] args) { }
        public static void LucyChaseGun() { }
        public static void LucyChaseGun(params object[] args) { }
        public static void LucyChaseSelf() { }
        public static void LucyChaseSelf(params object[] args) { }
        public static dynamic lucyDelay;
        public static void LucyHarassGun() { }
        public static void LucyHarassGun(params object[] args) { }
        public static void Lurker() { }
        public static void Lurker(params object[] args) { }
        public static void LurkerAttack() { }
        public static void LurkerAttack(params object[] args) { }
        public static void LurkerAttackAll() { }
        public static void LurkerAttackAll(params object[] args) { }
        public static void LurkerAttackGun() { }
        public static void LurkerAttackGun(params object[] args) { }
        public static void MakeRoomPrivate() { }
        public static void MakeRoomPrivate(params object[] args) { }
        public static void MakeRoomPublic() { }
        public static void MakeRoomPublic(params object[] args) { }
        public static void MasterCrashAll() { }
        public static void MasterCrashAll(params object[] args) { }
        public static void MasterCrashGun() { }
        public static void MasterCrashGun(params object[] args) { }
        public static int masterVisualizationType;
        public static void MasterVisualizationType() { }
        public static void MasterVisualizationType(bool positive) { }
        public static void MaterialAll() { }
        public static void MaterialAll(params object[] args) { }
        public static dynamic materialDelay;
        public static void MaterialGun() { }
        public static void MaterialGun(params object[] args) { }
        public static void MaterialTarget() { }
        public static void MaterialTarget(params object[] args) { }
        public static void MoveLucyGun() { }
        public static void MoveLucyGun(params object[] args) { }
        public static void MoveLurkerGun() { }
        public static void MoveLurkerGun(params object[] args) { }
        public static dynamic muteOnFreeze;
        public static void NoclipAll() { }
        public static void NoclipAll(params object[] args) { }
        public static void NoclipGun() { }
        public static void NoclipGun(params object[] args) { }
        public static dynamic NoTeleportSnowballs;
        public static Dictionary<string, int> ObjectByName = new Dictionary<string, int>();
        public static void ObjectGun() { }
        public static void ObjectGun(params object[] args) { }
        public static void ObjectSpam() { }
        public static void ObjectSpam(params object[] args) { }
        public static void ObliteratePlayer() { }
        public static void ObliteratePlayer(params object[] args) { }
        public static void OnSnowballHit(SlingshotProjectile projectile, UnityEngine.Collision collision) { }
        public static void OnSnowballHit(params object[] args) { }
        public static dynamic OptimizeEvents;
        public static void OrbitAll() { }
        public static void OrbitAll(params object[] args) { }
        public static void PaintbrawlGamemode() { }
        public static void PaintbrawlGamemode(params object[] args) { }
        public static void PartyBreakNetworkTriggers() { }
        public static void PartyBreakNetworkTriggers(params object[] args) { }
        public static void PartyKickAll() { }
        public static void PartyKickAll(params object[] args) { }
        public static void PartyKickAura() { }
        public static void PartyKickAura(params object[] args) { }
        public static void PartyKickGun() { }
        public static void PartyKickGun(params object[] args) { }
        public static void PartyKickOnTouch() { }
        public static void PartyKickOnTouch(params object[] args) { }
        public static void PhysicalFreezeAll() { }
        public static void PhysicalFreezeAll(params object[] args) { }
        public static void PhysicalFreezeGun() { }
        public static void PhysicalFreezeGun(params object[] args) { }
        public static void PunchMod() { }
        public static void PunchMod(params object[] args) { }
        public static void RainEntities() { }
        public static void RainEntities(params object[] args) { }
        public static void RainGadgets() { }
        public static void RainGadgets(params object[] args) { }
        public static dynamic rejoinOnKick;
        public static void ReleaseAll() { }
        public static void ReleaseAll(params object[] args) { }
        public static void ReleaseGun() { }
        public static void ReleaseGun(params object[] args) { }
        public static void RemoveSelfFromLeaderboard() { }
        public static void RemoveSelfFromLeaderboard(params object[] args) { }
        public static void RepairKick() { }
        public static void RepairKick(params object[] args) { }
        public static void ResourceSpamGrip() { }
        public static void ResourceSpamGrip(params object[] args) { }
        public static void ResourceSpamGun() { }
        public static void ResourceSpamGun(params object[] args) { }
        public static void RockAll() { }
        public static void RockAll(params object[] args) { }
        public static void RockAura() { }
        public static void RockAura(params object[] args) { }
        public static void RockGun() { }
        public static void RockGun(params object[] args) { }
        public static void RockOnTouch() { }
        public static void RockOnTouch(params object[] args) { }
        public static void RockSelf() { }
        public static void RockSelf(params object[] args) { }
        public static void ServerMuteAll() { }
        public static void ServerMuteAll(params object[] args) { }
        public static void SetColorAll() { }
        public static void SetColorAll(params object[] args) { }
        public static void SetColorGun() { }
        public static void SetColorGun(params object[] args) { }
        public static void SetColorSelf() { }
        public static void SetColorSelf(params object[] args) { }
        public static void SetMasterClient() { }
        public static void SetMasterClient(params object[] args) { }
        public static void SetMasterGun() { }
        public static void SetMasterGun(params object[] args) { }
        public static void SetRoomStatus() { }
        public static void SetRoomStatus(params object[] args) { }
        public static void SillyFace() { }
        public static void SillyFace(params object[] args) { }
        public static void SizeChanger() { }
        public static void SizeChanger(params object[] args) { }
        public static void SlowAll() { }
        public static void SlowAll(params object[] args) { }
        public static void SlowAura() { }
        public static void SlowAura(params object[] args) { }
        public static void SlowGun() { }
        public static void SlowGun(params object[] args) { }
        public static void SlowLucy() { }
        public static void SlowLucy(params object[] args) { }
        public static void SlowOnTouch() { }
        public static void SlowOnTouch(params object[] args) { }
        public static void SlowSelf() { }
        public static void SlowSelf(params object[] args) { }
        public static void SnowballAirstrikeGun() { }
        public static void SnowballAirstrikeGun(params object[] args) { }
        public static void SnowballAura() { }
        public static void SnowballAura(params object[] args) { }
        public static void SnowballBomb() { }
        public static void SnowballBomb(params object[] args) { }
        public static void SnowballBoxing() { }
        public static void SnowballBoxing(params object[] args) { }
        public static void SnowballDash() { }
        public static void SnowballDash(params object[] args) { }
        public static void SnowballFlingAll() { }
        public static void SnowballFlingAll(params object[] args) { }
        public static void SnowballFlingAwayGun() { }
        public static void SnowballFlingAwayGun(params object[] args) { }
        public static void SnowballFlingGun() { }
        public static void SnowballFlingGun(params object[] args) { }
        public static void SnowballFlingPlayerAwayGun() { }
        public static void SnowballFlingPlayerAwayGun(params object[] args) { }
        public static void SnowballFlingPlayerTowardsGun() { }
        public static void SnowballFlingPlayerTowardsGun(params object[] args) { }
        public static void SnowballFlingTowardsGun() { }
        public static void SnowballFlingTowardsGun(params object[] args) { }
        public static void SnowballFlingVerticalAll() { }
        public static void SnowballFlingVerticalAll(params object[] args) { }
        public static void SnowballFlingVerticalGun() { }
        public static void SnowballFlingVerticalGun(params object[] args) { }
        public static void SnowballFlingZone() { }
        public static void SnowballFlingZone(params object[] args) { }
        public static void SnowballFountain() { }
        public static void SnowballFountain(params object[] args) { }
        public static void SnowballGrenade() { }
        public static void SnowballGrenade(params object[] args) { }
        public static void SnowballGun() { }
        public static void SnowballGun(params object[] args) { }
        public static void SnowballHail() { }
        public static void SnowballHail(params object[] args) { }
        public static void SnowballHighJump() { }
        public static void SnowballHighJump(params object[] args) { }
        public static void SnowballImpactEffectGun() { }
        public static void SnowballImpactEffectGun(params object[] args) { }
        public static void SnowballLaunchGun() { }
        public static void SnowballLaunchGun(params object[] args) { }
        public static void SnowballMinigun() { }
        public static void SnowballMinigun(params object[] args) { }
        public static dynamic snowballMultiplicationFactor;
        public static void SnowballMushroom() { }
        public static void SnowballMushroom(params object[] args) { }
        public static void SnowballNukeGun() { }
        public static void SnowballNukeGun(params object[] args) { }
        public static void SnowballOrbit() { }
        public static void SnowballOrbit(params object[] args) { }
        public static void SnowballParticleGun() { }
        public static void SnowballParticleGun(params object[] args) { }
        public static void SnowballPositionalFountain() { }
        public static void SnowballPositionalFountain(params object[] args) { }
        public static void SnowballPunchMod() { }
        public static void SnowballPunchMod(params object[] args) { }
        public static void SnowballRain() { }
        public static void SnowballRain(params object[] args) { }
        public static void SnowballRPG() { }
        public static void SnowballRPG(params object[] args) { }
        public static void SnowballSafetyBubble() { }
        public static void SnowballSafetyBubble(params object[] args) { }
        public static dynamic snowballScale;
        public static void SnowballShotgun() { }
        public static void SnowballShotgun(params object[] args) { }
        public static void SnowballSpam() { }
        public static void SnowballSpam(params object[] args) { }
        public static dynamic SnowballSpawnDelay;
        public static void SnowballWall() { }
        public static void SnowballWall(params object[] args) { }
        public static void SpamEntityGrip() { }
        public static void SpamEntityGrip(params object[] args) { }
        public static void SpamEntityGun() { }
        public static void SpamEntityGun(params object[] args) { }
        public static void SpamGadgetGrip() { }
        public static void SpamGadgetGrip(params object[] args) { }
        public static void SpamGadgetGun() { }
        public static void SpamGadgetGun(params object[] args) { }
        public static void SpamObjectGrip() { }
        public static void SpamObjectGrip(params object[] args) { }
        public static void SpamObjectGun() { }
        public static void SpamObjectGun(params object[] args) { }
        public static void SpawnBlueLucy() { }
        public static void SpawnBlueLucy(params object[] args) { }
        public static void SpawnRedLucy() { }
        public static void SpawnRedLucy(params object[] args) { }
        public static void SpazAllPlayers() { }
        public static void SpazAllPlayers(params object[] args) { }
        public static void SpazAllRopes() { }
        public static void SpazAllRopes(params object[] args) { }
        public static void SpazDriver() { }
        public static void SpazDriver(params object[] args) { }
        public static void SpazDriverStatusGun() { }
        public static void SpazDriverStatusGun(params object[] args) { }
        public static void SpazGamemode() { }
        public static void SpazGamemode(params object[] args) { }
        public static void SpazGrabbedRopes() { }
        public static void SpazGrabbedRopes(params object[] args) { }
        public static void SpazGreyZone() { }
        public static void SpazGreyZone(params object[] args) { }
        public static void SpazGreyZoneGun() { }
        public static void SpazGreyZoneGun(params object[] args) { }
        public static void SpazLava() { }
        public static void SpazLava(params object[] args) { }
        public static void SpazLucy() { }
        public static void SpazLucy(params object[] args) { }
        public static void SpazLurker() { }
        public static void SpazLurker(params object[] args) { }
        public static void SpazPlayerGun() { }
        public static void SpazPlayerGun(params object[] args) { }
        public static void SpazPropHunt() { }
        public static void SpazPropHunt(params object[] args) { }
        public static void SpazPropHuntObjects() { }
        public static void SpazPropHuntObjects(params object[] args) { }
        public static void SpazRopeGun() { }
        public static void SpazRopeGun(params object[] args) { }
        public static void SpecialTargetRPC() { }
        public static void SpecialTargetRPC(params object[] args) { }
        public static dynamic specificRoom;
        public static void SSDisableNetworkTriggers() { }
        public static void SSDisableNetworkTriggers(params object[] args) { }
        public static void StartMoonEvent() { }
        public static void StartMoonEvent(params object[] args) { }
        public static void Strobe() { }
        public static void Strobe(params object[] args) { }
        public static void StrobeColorAll() { }
        public static void StrobeColorAll(params object[] args) { }
        public static void StrobeColorGun() { }
        public static void StrobeColorGun(params object[] args) { }
        public static void StrobeColorSelf() { }
        public static void StrobeColorSelf(params object[] args) { }
        public static void StumpKickAll() { }
        public static void StumpKickAll(params object[] args) { }
        public static void StumpKickGun() { }
        public static void StumpKickGun(params object[] args) { }
        public static void SuperInfectionBreakAudioAll() { }
        public static void SuperInfectionBreakAudioAll(params object[] args) { }
        public static void SuperInfectionBreakAudioGun() { }
        public static void SuperInfectionBreakAudioGun(params object[] args) { }
        public static void SuperInfectionCrashAll() { }
        public static void SuperInfectionCrashAll(params object[] args) { }
        public static void SuperInfectionCrashGun() { }
        public static void SuperInfectionCrashGun(params object[] args) { }
        public static void SuperInfectionDrawGun() { }
        public static void SuperInfectionDrawGun(params object[] args) { }
        public static void SuperInfectionTextGun() { }
        public static void SuperInfectionTextGun(params object[] args) { }
        public static void TagToInfection() { }
        public static void TagToInfection(params object[] args) { }
        public static void TargetSpam() { }
        public static void TargetSpam(params object[] args) { }
        public static void Testicles() { }
        public static void Testicles(params object[] args) { }
        public static dynamic textDelay;
        public static dynamic textToRender;
        public static void ToolSpamGrip() { }
        public static void ToolSpamGrip(params object[] args) { }
        public static void ToolSpamGun() { }
        public static void ToolSpamGun(params object[] args) { }
        public static void TowardsPointOnGrab() { }
        public static void TowardsPointOnGrab(params object[] args) { }
        public static void TowardsPositionOnGrab() { }
        public static void TowardsPositionOnGrab(params object[] args) { }
        public static void TransgenderFlag() { }
        public static void TransgenderFlag(params object[] args) { }
        public static void TrapStump() { }
        public static void TrapStump(params object[] args) { }
        public static void UnguardianAll() { }
        public static void UnguardianAll(params object[] args) { }
        public static void UnguardianGun() { }
        public static void UnguardianGun(params object[] args) { }
        public static void UnguardianSelf() { }
        public static void UnguardianSelf(params object[] args) { }
        public static void UnloadPeerBase() { }
        public static void UnloadPeerBase(params object[] args) { }
        public static void UnlockAllGadgets() { }
        public static void UnlockAllGadgets(params object[] args) { }
        public static void VibrateAll() { }
        public static void VibrateAll(params object[] args) { }
        public static void VibrateAura() { }
        public static void VibrateAura(params object[] args) { }
        public static void VibrateGun() { }
        public static void VibrateGun(params object[] args) { }
        public static void VibrateOnTouch() { }
        public static void VibrateOnTouch(params object[] args) { }
        public static void VibrateSelf() { }
        public static void VibrateSelf(params object[] args) { }
        public static void VirtualStumpCrashAll() { }
        public static void VirtualStumpCrashAll(params object[] args) { }
        public static void VirtualStumpCrashGun() { }
        public static void VirtualStumpCrashGun(params object[] args) { }
        public static void VirtualStumpKickAll() { }
        public static void VirtualStumpKickAll(params object[] args) { }
        public static void VirtualStumpKickGun() { }
        public static void VirtualStumpKickGun(params object[] args) { }
        public static void ZaWarudo() { }
        public static void ZaWarudo(params object[] args) { }
        public static void ZaWarudo_enableMethod() { }
        public static void ZaWarudo_enableMethod(params object[] args) { }
    }

    public static class Projectiles
    {
        public static void BetaFireProjectile() { }
        public static void BetaFireProjectile(params object[] args) { }
        public static void BlackSnowballs() { }
        public static void BlackSnowballs(params object[] args) { }
        public static dynamic blue;
        public static void ChangeGrowingProjectile() { }
        public static void ChangeGrowingProjectile(params object[] args) { }
        public static void ChangeProjectile() { }
        public static void ChangeProjectile(params object[] args) { }
        public static void ChangeProjectileDelay() { }
        public static void ChangeProjectileDelay(params object[] args) { }
        public static void ChangeProjectileIndex() { }
        public static void ChangeProjectileIndex(params object[] args) { }
        public static void ChangeShootSpeed() { }
        public static void ChangeShootSpeed(params object[] args) { }
        public static dynamic clientSided;
        public static void DisableInstantCrankElf() { }
        public static void DisableInstantCrankElf(params object[] args) { }
        public static void DisableProjectile() { }
        public static void DisableProjectile(params object[] args) { }
        public static void DisableProjectileBomb() { }
        public static void DisableProjectileBomb(params object[] args) { }
        public static void ElfAirstrikeGun() { }
        public static void ElfAirstrikeGun(params object[] args) { }
        public static void ElfAnnoyGun() { }
        public static void ElfAnnoyGun(params object[] args) { }
        public static void ElfGun() { }
        public static void ElfGun(params object[] args) { }
        public static void ElfLauncherSpam() { }
        public static void ElfLauncherSpam(params object[] args) { }
        public static void Feces() { }
        public static void Feces(params object[] args) { }
        public static void FecesGun() { }
        public static void FecesGun(params object[] args) { }
        public static void FixBlackSnowballs() { }
        public static void FixBlackSnowballs(params object[] args) { }
        public static void FriendProjectileScale() { }
        public static void FriendProjectileScale(params object[] args) { }
        public static dynamic friendSided;
        public static void GiveProjectileSpamGun() { }
        public static void GiveProjectileSpamGun(params object[] args) { }
        public static void GrabProjectile() { }
        public static void GrabProjectile(params object[] args) { }
        public static dynamic green;
        public static void ImpactSpam() { }
        public static void ImpactSpam(params object[] args) { }
        public static void IncreaseBlue() { }
        public static void IncreaseBlue(params object[] args) { }
        public static void IncreaseGreen() { }
        public static void IncreaseGreen(params object[] args) { }
        public static void IncreaseRed() { }
        public static void IncreaseRed(params object[] args) { }
        public static void InstantCrankElf() { }
        public static void InstantCrankElf(params object[] args) { }
        public static void LaunchLocalProjectile() { }
        public static void LaunchLocalProjectile(params object[] args) { }
        public static void LazerEyes() { }
        public static void LazerEyes(params object[] args) { }
        public static void LazerEyesGun() { }
        public static void LazerEyesGun(params object[] args) { }
        public static void LazerSpam() { }
        public static void LazerSpam(params object[] args) { }
        public static void NoRandomColorSnowballs() { }
        public static void NoRandomColorSnowballs(params object[] args) { }
        public static void Period() { }
        public static void Period(params object[] args) { }
        public static void PeriodGun() { }
        public static void PeriodGun(params object[] args) { }
        public static dynamic projDebounceIndex;
        public static void ProjectileBlindAll() { }
        public static void ProjectileBlindAll(params object[] args) { }
        public static void ProjectileBlindGun() { }
        public static void ProjectileBlindGun(params object[] args) { }
        public static void ProjectileBlindPlayer() { }
        public static void ProjectileBlindPlayer(params object[] args) { }
        public static void ProjectileBomb() { }
        public static void ProjectileBomb(params object[] args) { }
        public static void ProjectileGun() { }
        public static void ProjectileGun(params object[] args) { }
        public static void ProjectileLagAll() { }
        public static void ProjectileLagAll(params object[] args) { }
        public static void ProjectileLagGun() { }
        public static void ProjectileLagGun(params object[] args) { }
        public static void ProjectileLagPlayer() { }
        public static void ProjectileLagPlayer(params object[] args) { }
        public static void ProjectileObjectNames() { }
        public static void ProjectileObjectNames(params object[] args) { }
        public static void ProjectileSpam() { }
        public static void ProjectileSpam(params object[] args) { }
        public static dynamic projMode;
        public static void RandomColorSnowballs() { }
        public static void RandomColorSnowballs(params object[] args) { }
        public static dynamic red;
        public static void Semen() { }
        public static void Semen(params object[] args) { }
        public static void SemenGun() { }
        public static void SemenGun(params object[] args) { }
        public static dynamic shootCycle;
        public static dynamic snowballIndex;
        public static string SnowballName = "GrowingSnowball";
        public static void Spit() { }
        public static void Spit(params object[] args) { }
        public static void SpitGun() { }
        public static void SpitGun(params object[] args) { }
        public static dynamic targetProjectileIndex;
        public static void Urine() { }
        public static void Urine(params object[] args) { }
        public static void UrineGun() { }
        public static void UrineGun(params object[] args) { }
        public static void Vomit() { }
        public static void Vomit(params object[] args) { }
        public static void VomitGun() { }
        public static void VomitGun(params object[] args) { }
    }

    public static class Safety
    {
        public static void AntiContentCreator() { }
        public static void AntiContentCreator(params object[] args) { }
        public static void AntiLurker() { }
        public static void AntiLurker(params object[] args) { }
        public static void AntiModerator() { }
        public static void AntiModerator(params object[] args) { }
        public static dynamic antiMute;
        public static void AntiNameBan() { }
        public static void AntiNameBan(params object[] args) { }
        public static void AntiPredictions() { }
        public static void AntiPredictions(params object[] args) { }
        public static void AntiReport(Action<VRRig, UnityEngine.Vector3> callback) { }
        public static void AntiReport(params object[] args) { }
        public static void AntiReportCrash() { }
        public static void AntiReportCrash(params object[] args) { }
        public static void AntiReportDisconnect() { }
        public static void AntiReportDisconnect(params object[] args) { }
        public static void AntiReportFRT() { }
        public static void AntiReportFRT(params object[] args) { }
        public static void AntiReportJoinRandom() { }
        public static void AntiReportJoinRandom(params object[] args) { }
        public static void AntiReportLag() { }
        public static void AntiReportLag(params object[] args) { }
        public static void AntiReportNotify() { }
        public static void AntiReportNotify(params object[] args) { }
        public static void AntiReportOverlay() { }
        public static void AntiReportOverlay(params object[] args) { }
        public static dynamic antiReportRangeIndex;
        public static void AntiReportReconnect() { }
        public static void AntiReportReconnect(params object[] args) { }
        public static void AutoClearCache() { }
        public static void AutoClearCache(params object[] args) { }
        public static void BypassAutomod() { }
        public static void BypassAutomod(params object[] args) { }
        public static void BypassModCheckers() { }
        public static void BypassModCheckers(params object[] args) { }
        public static void ChangeAntiReportRange() { }
        public static void ChangeAntiReportRange(params object[] args) { }
        public static void ChangeBadgeTier() { }
        public static void ChangeBadgeTier(params object[] args) { }
        public static void ChangeELOValue() { }
        public static void ChangeELOValue(params object[] args) { }
        public static void ChangeFPSSpoofValue() { }
        public static void ChangeFPSSpoofValue(params object[] args) { }
        public static void ChangeIdentity() { }
        public static void ChangeIdentity(params object[] args) { }
        public static void ChangeIdentityCustom() { }
        public static void ChangeIdentityCustom(params object[] args) { }
        public static void ChangeIdentityOnDisconnect(Action action) { }
        public static void ChangeIdentityOnDisconnect(params object[] args) { }
        public static void ChangeIdentityRegular() { }
        public static void ChangeIdentityRegular(params object[] args) { }
        public static void ChangePingSpoofValue() { }
        public static void ChangePingSpoofValue(params object[] args) { }
        public static void ChangeRankedTier() { }
        public static void ChangeRankedTier(params object[] args) { }
        public static void ColorSpoof() { }
        public static void ColorSpoof(params object[] args) { }
        public static void CosmeticNotifications() { }
        public static void CosmeticNotifications(params object[] args) { }
        public static void DisableAntiOculusReport() { }
        public static void DisableAntiOculusReport(params object[] args) { }
        public static void DisableGeneral() { }
        public static void DisableGeneral(params object[] args) { }
        public static void DisableSmartAntiReport() { }
        public static void DisableSmartAntiReport(params object[] args) { }
        public static void EnableAntiOculusReport() { }
        public static void EnableAntiOculusReport(params object[] args) { }
        public static void EnableSmartAntiReport() { }
        public static void EnableSmartAntiReport(params object[] args) { }
        public static void FakeBrokenController() { }
        public static void FakeBrokenController(params object[] args) { }
        public static void FakeOculusMenu() { }
        public static void FakeOculusMenu(params object[] args) { }
        public static void FakePowerOff() { }
        public static void FakePowerOff(params object[] args) { }
        public static void FakeReportMenu() { }
        public static void FakeReportMenu(params object[] args) { }
        public static void FakeValveTracking() { }
        public static void FakeValveTracking(params object[] args) { }
        public static void FPSSpoof() { }
        public static void FPSSpoof(params object[] args) { }
        public static dynamic fpsSpoofValue;
        public static void GeneralSafety() { }
        public static void GeneralSafety(params object[] args) { }
        public static void NameSpoof() { }
        public static void NameSpoof(params object[] args) { }
        public static void NoFinger() { }
        public static void NoFinger(params object[] args) { }
        public static void PingSpoof() { }
        public static void PingSpoof(params object[] args) { }
        public static dynamic pingSpoofValue;
        public static dynamic rankIndex;
        public static void SetGamemodeButtonActive() { }
        public static void SetGamemodeButtonActive(params object[] args) { }
        public static void SpoofBadge() { }
        public static void SpoofBadge(params object[] args) { }
        public static void SpoofPlatform() { }
        public static void SpoofPlatform(params object[] args) { }
        public static void SpoofRank() { }
        public static void SpoofRank(params object[] args) { }
        public static void SpoofSupportPage() { }
        public static void SpoofSupportPage(params object[] args) { }
        public static dynamic targetBadge;
        public static dynamic targetElo;
        public static dynamic targetRank;
        public static void VisualizeAntiReport() { }
        public static void VisualizeAntiReport(params object[] args) { }
    }

    public static class Visuals
    {
        public static dynamic anchorNameTag;
        public static void AudioVisualizer() { }
        public static void AudioVisualizer(params object[] args) { }
        public static Dictionary<(long, float), GameObject> auraPool = new Dictionary<(long, float), GameObject>();
        public static void AutomaticESP(Action first, Action second, Action third) { }
        public static void AutomaticESP(params object[] args) { }
        public static void BetterRigLerping(VRRig rig) { }
        public static void BetterRigLerping(params object[] args) { }
        public static dynamic bones;
        public static void CastingTags() { }
        public static void CastingTags(params object[] args) { }
        public static void CasualBeacons() { }
        public static void CasualBeacons(params object[] args) { }
        public static void CasualBoneESP() { }
        public static void CasualBoneESP(params object[] args) { }
        public static void CasualBoxESP() { }
        public static void CasualBoxESP(params object[] args) { }
        public static void CasualBreadcrumbs() { }
        public static void CasualBreadcrumbs(params object[] args) { }
        public static void CasualChams() { }
        public static void CasualChams(params object[] args) { }
        public static void CasualDistanceESP() { }
        public static void CasualDistanceESP(params object[] args) { }
        public static void CasualHollowBoxESP() { }
        public static void CasualHollowBoxESP(params object[] args) { }
        public static void CasualSkeletonESP() { }
        public static void CasualSkeletonESP(params object[] args) { }
        public static void CasualTracers() { }
        public static void CasualTracers(params object[] args) { }
        public static void CasualWireframeESP() { }
        public static void CasualWireframeESP(params object[] args) { }
        public static void Chams() { }
        public static void Chams(params object[] args) { }
        public static void ChangePerformanceModeVisualStep() { }
        public static void ChangePerformanceModeVisualStep(params object[] args) { }
        public static void ClearLinePool() { }
        public static void ClearLinePool(params object[] args) { }
        public static void ClearNameTagPool() { }
        public static void ClearNameTagPool(params object[] args) { }
        public static void CompactTags() { }
        public static void CompactTags(params object[] args) { }
        public static void ConductDebug() { }
        public static void ConductDebug(params object[] args) { }
        public static void ConsoleBeacon() { }
        public static void ConsoleBeacon(params object[] args) { }
        public static void CoreESP() { }
        public static void CoreESP(params object[] args) { }
        public static void CosmeticESP() { }
        public static void CosmeticESP(params object[] args) { }
        public static void CosmeticTags() { }
        public static void CosmeticTags(params object[] args) { }
        public static void CrashedTags() { }
        public static void CrashedTags(params object[] args) { }
        public static void CreateAudioVisualizer() { }
        public static void CreateAudioVisualizer(params object[] args) { }
        public static void CreationDateTags() { }
        public static void CreationDateTags(params object[] args) { }
        public static void CreatureESP() { }
        public static void CreatureESP(params object[] args) { }
        public static void CritterESP() { }
        public static void CritterESP(params object[] args) { }
        public static Dictionary<(Vector3, Quaternion, Vector3), GameObject> cubePool = new Dictionary<(Vector3, Quaternion, Vector3), GameObject>();
        public static void CustomSkyboxColor() { }
        public static void CustomSkyboxColor(params object[] args) { }
        public static void DestroyAudioVisualizer() { }
        public static void DestroyAudioVisualizer(params object[] args) { }
        public static void DisableAmbience() { }
        public static void DisableAmbience(params object[] args) { }
        public static void DisableBoneESP() { }
        public static void DisableBoneESP(params object[] args) { }
        public static void DisableBoxESP() { }
        public static void DisableBoxESP(params object[] args) { }
        public static void DisableBreadcrumbs() { }
        public static void DisableBreadcrumbs(params object[] args) { }
        public static void DisableCastingTags() { }
        public static void DisableCastingTags(params object[] args) { }
        public static void DisableChams() { }
        public static void DisableChams(params object[] args) { }
        public static void DisableCompactTags() { }
        public static void DisableCompactTags(params object[] args) { }
        public static void DisableCosmeticESP() { }
        public static void DisableCosmeticESP(params object[] args) { }
        public static void DisableCosmetics() { }
        public static void DisableCosmetics(params object[] args) { }
        public static void DisableCosmeticTags() { }
        public static void DisableCosmeticTags(params object[] args) { }
        public static void DisableCrashedTags() { }
        public static void DisableCrashedTags(params object[] args) { }
        public static void DisableCreationDateTags() { }
        public static void DisableCreationDateTags(params object[] args) { }
        public static void DisableDebugHUD() { }
        public static void DisableDebugHUD(params object[] args) { }
        public static void DisableDrawGun() { }
        public static void DisableDrawGun(params object[] args) { }
        public static void DisableFog() { }
        public static void DisableFog(params object[] args) { }
        public static void DisableFPSTags() { }
        public static void DisableFPSTags(params object[] args) { }
        public static void DisableGamesenseRing() { }
        public static void DisableGamesenseRing(params object[] args) { }
        public static void DisableHitboxPredictions() { }
        public static void DisableHitboxPredictions(params object[] args) { }
        public static void DisableHollowBoxESP() { }
        public static void DisableHollowBoxESP(params object[] args) { }
        public static void DisableIDTags() { }
        public static void DisableIDTags(params object[] args) { }
        public static void DisableJumpPredictions() { }
        public static void DisableJumpPredictions(params object[] args) { }
        public static void DisableKIDNameTags() { }
        public static void DisableKIDNameTags(params object[] args) { }
        public static void DisableLatencyDebugOverlayPlus() { }
        public static void DisableLatencyDebugOverlayPlus(params object[] args) { }
        public static void DisableMinecraftTags() { }
        public static void DisableMinecraftTags(params object[] args) { }
        public static void DisableModTags() { }
        public static void DisableModTags(params object[] args) { }
        public static void DisableNameTags() { }
        public static void DisableNameTags(params object[] args) { }
        public static void DisablePaintbrawlTrajectories() { }
        public static void DisablePaintbrawlTrajectories(params object[] args) { }
        public static void DisablePingTags() { }
        public static void DisablePingTags(params object[] args) { }
        public static void DisablePlatformIndicators() { }
        public static void DisablePlatformIndicators(params object[] args) { }
        public static void DisablePlatformTags() { }
        public static void DisablePlatformTags(params object[] args) { }
        public static void DisableRemoveCherryBlossoms() { }
        public static void DisableRemoveCherryBlossoms(params object[] args) { }
        public static void DisableRemoveLeaves() { }
        public static void DisableRemoveLeaves(params object[] args) { }
        public static void DisableShaderChams() { }
        public static void DisableShaderChams(params object[] args) { }
        public static void DisableShowServerPosition() { }
        public static void DisableShowServerPosition(params object[] args) { }
        public static void DisableSkeletonESP() { }
        public static void DisableSkeletonESP(params object[] args) { }
        public static void DisableStreamerRemoveLeaves() { }
        public static void DisableStreamerRemoveLeaves(params object[] args) { }
        public static void DisableSubscriberNameTags() { }
        public static void DisableSubscriberNameTags(params object[] args) { }
        public static void DisableTaggedTags() { }
        public static void DisableTaggedTags(params object[] args) { }
        public static void DisableTurnTags() { }
        public static void DisableTurnTags(params object[] args) { }
        public static void DisableVelocityTags() { }
        public static void DisableVelocityTags(params object[] args) { }
        public static void DisableVerifiedTags() { }
        public static void DisableVerifiedTags(params object[] args) { }
        public static void DisableVoiceIndicators() { }
        public static void DisableVoiceIndicators(params object[] args) { }
        public static void DisableWireframeESP() { }
        public static void DisableWireframeESP(params object[] args) { }
        public static void DoCustomSkyboxColor() { }
        public static void DoCustomSkyboxColor(params object[] args) { }
        public static void DoPerformanceCheck() { }
        public static void DoPerformanceCheck(params object[] args) { }
        public static void DrawGun() { }
        public static void DrawGun(params object[] args) { }
        public static void DrawTrajectory() { }
        public static void DrawTrajectory(params object[] args) { }
        public static void EnableAmbience() { }
        public static void EnableAmbience(params object[] args) { }
        public static void EnableCosmetics() { }
        public static void EnableCosmetics(params object[] args) { }
        public static void EnableDebugHUD() { }
        public static void EnableDebugHUD(params object[] args) { }
        public static void EnableFog() { }
        public static void EnableFog(params object[] args) { }
        public static void EnableRemoveCherryBlossoms() { }
        public static void EnableRemoveCherryBlossoms(params object[] args) { }
        public static void EnableRemoveLeaves() { }
        public static void EnableRemoveLeaves(params object[] args) { }
        public static void EnableStreamerRemoveLeaves() { }
        public static void EnableStreamerRemoveLeaves(params object[] args) { }
        public static void EndNoLimb() { }
        public static void EndNoLimb(params object[] args) { }
        public static void EnemyESP() { }
        public static void EnemyESP(params object[] args) { }
        public static void ExtraRoomInfo() { }
        public static void ExtraRoomInfo(params object[] args) { }
        public static void FakeUnbanSelf() { }
        public static void FakeUnbanSelf(params object[] args) { }
        public static void FixRigColors() { }
        public static void FixRigColors(params object[] args) { }
        public static void FixRigMaterialESPColors() { }
        public static void FixRigMaterialESPColors(params object[] args) { }
        public static void FPSTags() { }
        public static void FPSTags(params object[] args) { }
        public static void GamesenseRing() { }
        public static void GamesenseRing(params object[] args) { }
        public static void GetLabel() { }
        public static void GetLabel(params object[] args) { }
        public static void GetLineRender() { }
        public static void GetLineRender(params object[] args) { }
        public static void GetNameTagPosition() { }
        public static void GetNameTagPosition(params object[] args) { }
        public static void HideButtonColliders() { }
        public static void HideButtonColliders(params object[] args) { }
        public static void HitboxPredictions() { }
        public static void HitboxPredictions(params object[] args) { }
        public static void HollowHuntBoxESP() { }
        public static void HollowHuntBoxESP(params object[] args) { }
        public static void HollowInfectionBoxESP() { }
        public static void HollowInfectionBoxESP(params object[] args) { }
        public static void HuntBeacons() { }
        public static void HuntBeacons(params object[] args) { }
        public static void HuntBoneESP() { }
        public static void HuntBoneESP(params object[] args) { }
        public static void HuntBoxESP() { }
        public static void HuntBoxESP(params object[] args) { }
        public static void HuntBreadcrumbs() { }
        public static void HuntBreadcrumbs(params object[] args) { }
        public static void HuntChams() { }
        public static void HuntChams(params object[] args) { }
        public static void HuntDistanceESP() { }
        public static void HuntDistanceESP(params object[] args) { }
        public static void HuntSkeletonESP() { }
        public static void HuntSkeletonESP(params object[] args) { }
        public static void HuntTracers() { }
        public static void HuntTracers(params object[] args) { }
        public static void HuntWireframeESP() { }
        public static void HuntWireframeESP(params object[] args) { }
        public static void IDTags() { }
        public static void IDTags(params object[] args) { }
        public static void InfectionBeacons() { }
        public static void InfectionBeacons(params object[] args) { }
        public static void InfectionBoneESP() { }
        public static void InfectionBoneESP(params object[] args) { }
        public static void InfectionBoxESP() { }
        public static void InfectionBoxESP(params object[] args) { }
        public static void InfectionBreadcrumbs() { }
        public static void InfectionBreadcrumbs(params object[] args) { }
        public static void InfectionChams() { }
        public static void InfectionChams(params object[] args) { }
        public static void InfectionDistanceESP() { }
        public static void InfectionDistanceESP(params object[] args) { }
        public static void InfectionSkeletonESP() { }
        public static void InfectionSkeletonESP(params object[] args) { }
        public static void InfectionTracers() { }
        public static void InfectionTracers(params object[] args) { }
        public static void InfectionWireframeESP() { }
        public static void InfectionWireframeESP(params object[] args) { }
        public static void InfoOverlayGun() { }
        public static void InfoOverlayGun(params object[] args) { }
        public static dynamic infoWatchClip;
        public static dynamic infoWatchCode;
        public static dynamic infoWatchFPS;
        public static dynamic infoWatchMenuName;
        public static dynamic infoWatchTime;
        public static dynamic isLineRenderQueued;
        public static dynamic isNameTagQueued;
        public static void JumpPredictions() { }
        public static void JumpPredictions(params object[] args) { }
        public static void KIDNameTags() { }
        public static void KIDNameTags(params object[] args) { }
        public static Dictionary<string, GameObject> labelDictionary = new Dictionary<string, GameObject>();
        public static void LastLabel() { }
        public static void LastLabel(params object[] args) { }
        public static void LatencyDebugOverlayPlus() { }
        public static void LatencyDebugOverlayPlus(params object[] args) { }
        public static void LeaderboardInfo() { }
        public static void LeaderboardInfo(params object[] args) { }
        public static void MinecraftTags() { }
        public static void MinecraftTags(params object[] args) { }
        public static dynamic modDictionary;
        public static void ModTags() { }
        public static void ModTags(params object[] args) { }
        public static dynamic nameTagChams;
        public static void NameTags() { }
        public static void NameTags(params object[] args) { }
        public static void NearbyTaggerLabel() { }
        public static void NearbyTaggerLabel(params object[] args) { }
        public static void NearbyTaggerOverlay() { }
        public static void NearbyTaggerOverlay(params object[] args) { }
        public static void NearestTracer() { }
        public static void NearestTracer(params object[] args) { }
        public static void NoLimbMode() { }
        public static void NoLimbMode(params object[] args) { }
        public static void NoSmoothRigs() { }
        public static void NoSmoothRigs(params object[] args) { }
        public static void OnHandTapGamesenseRing(VRRig rig, UnityEngine.Vector3 position) { }
        public static void OnHandTapGamesenseRing(params object[] args) { }
        public static string OverallPlaytime = string.Empty;
        public static void PaintbrawlTrajectories() { }
        public static void PaintbrawlTrajectories(params object[] args) { }
        public static dynamic PerformanceModeStepIndex;
        public static dynamic PerformanceVisuals;
        public static void PingOverlay() { }
        public static void PingOverlay(params object[] args) { }
        public static void PingTags() { }
        public static void PingTags(params object[] args) { }
        public static void PlatformESP() { }
        public static void PlatformESP(params object[] args) { }
        public static void PlatformIndicators() { }
        public static void PlatformIndicators(params object[] args) { }
        public static void PlatformTags() { }
        public static void PlatformTags(params object[] args) { }
        public static void RemoveBlindfold() { }
        public static void RemoveBlindfold(params object[] args) { }
        public static void ResetFog() { }
        public static void ResetFog(params object[] args) { }
        public static void ReSmoothRigs() { }
        public static void ReSmoothRigs(params object[] args) { }
        public static void ResourceESP() { }
        public static void ResourceESP(params object[] args) { }
        public static dynamic selfNameTag;
        public static void SetFullbrightStatus() { }
        public static void SetFullbrightStatus(params object[] args) { }
        public static void ShowButtonColliders() { }
        public static void ShowButtonColliders(params object[] args) { }
        public static void ShowScheduledObjects() { }
        public static void ShowScheduledObjects(params object[] args) { }
        public static void ShowServerPosition() { }
        public static void ShowServerPosition(params object[] args) { }
        public static void SpawnLightning() { }
        public static void SpawnLightning(params object[] args) { }
        public static dynamic specialCosmetics;
        public static void StartNoLimb() { }
        public static void StartNoLimb(params object[] args) { }
        public static void StrikeTimeOverlay() { }
        public static void StrikeTimeOverlay(params object[] args) { }
        public static void SubscriberNameTags() { }
        public static void SubscriberNameTags(params object[] args) { }
        public static void TaggedTags() { }
        public static void TaggedTags(params object[] args) { }
        public static void TimeLabel() { }
        public static void TimeLabel(params object[] args) { }
        public static void ToggleSnow() { }
        public static void ToggleSnow(params object[] args) { }
        public static void TurnTags() { }
        public static void TurnTags(params object[] args) { }
        public static void UnCustomSkyboxColor() { }
        public static void UnCustomSkyboxColor(params object[] args) { }
        public static void UpdatePlaytime() { }
        public static void UpdatePlaytime(params object[] args) { }
        public static void VelocityLabel() { }
        public static void VelocityLabel(params object[] args) { }
        public static void VelocityTags() { }
        public static void VelocityTags(params object[] args) { }
        public static void VerifiedTags() { }
        public static void VerifiedTags(params object[] args) { }
        public static void VisualizeAura() { }
        public static void VisualizeAura(params object[] args) { }
        public static void VisualizeAuraObject() { }
        public static void VisualizeAuraObject(params object[] args) { }
        public static void VisualizeCube() { }
        public static void VisualizeCube(params object[] args) { }
        public static void VisualizeCubeObject() { }
        public static void VisualizeCubeObject(params object[] args) { }
        public static void VisualizeMapTriggers() { }
        public static void VisualizeMapTriggers(params object[] args) { }
        public static void VisualizeNetworkTriggers() { }
        public static void VisualizeNetworkTriggers(params object[] args) { }
        public static void VisualizeWindBarriers() { }
        public static void VisualizeWindBarriers(params object[] args) { }
        public static void VoiceESP() { }
        public static void VoiceESP(params object[] args) { }
        public static void VoiceIndicators() { }
        public static void VoiceIndicators(params object[] args) { }
        public static void WatchOff() { }
        public static void WatchOff(params object[] args) { }
        public static void WatchOn() { }
        public static void WatchOn(params object[] args) { }
        public static void WatchStep() { }
        public static void WatchStep(params object[] args) { }
        public static void WeatherChange() { }
        public static void WeatherChange(params object[] args) { }
        public static void Xray() { }
        public static void Xray(params object[] args) { }
    }

}

