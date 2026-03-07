using System;
using System.Collections;
using UnityEngine;

namespace iiMenu.Patches.Menu
{
    public static class BanPatches
    {
        public static bool enabled;

        public static class AntiBanCrash1
        {
            public static bool enabled;
        }

        public static class CheckAutoBanListForName
        {
            public static bool CheckBanList(string nameToCheck) => true;
        }
    }

    public static class ClimbablePatch
    {
        public static bool enabled;
    }

    public static class CooldownPatch
    {
        public static bool enabled;
    }

    public static class DreidelPatch
    {
        public static bool enabled;
    }

    public static class EnablePatch
    {
        public static bool enabled;
    }

    public static class EntityGrabPatch
    {
        public static bool enabled;
    }

    public static class FirePatch
    {
        public static bool enabled;
    }

    public static class JoinedRoomPatch
    {
        public static bool enabled;
    }

    public static class MultiplyKnockbackPatch
    {
        public static bool enabled;
    }

    public static class MultiplyKnockback
    {
        public static bool enabled;
    }

    public static class MultiplySelfKnockbackPatch
    {
        public static bool enabled;
    }

    public static class PopulatePatch
    {
        public static bool enabled;
    }

    public static class PurchasePatch
    {
        public static bool enabled;
    }

    public static class QuitBoxPatch
    {
        public static bool enabled = true;
        public static bool teleportToStump;
    }

    public static class RankedPatch
    {
        public static bool enabled;
        public static string targetTier;
        public static string targetPlatform;
    }

    public static class ReleasePatch
    {
        public static bool enabled;
    }

    public static class RequestPatch
    {
        public static bool enabled;
        public static bool bypassCosmeticCheck;
        public static Coroutine currentCoroutine;

        public static IEnumerator LoadCosmetics()
        {
            yield break;
        }
    }

    public static class SetColorPatch
    {
    }

    public static class SetRankedPatch
    {
        public static bool enabled;
    }

    public static class TorsoPatch
    {
        public static event Action VRRigLateUpdate;
        public static bool enabled;
        public static int mode;

        public static void InvokeLateUpdate() => VRRigLateUpdate?.Invoke();
    }

    public static class VelocityPatches
    {
        public static bool enabled;
        public static float multipleFactor = 1f;
    }
}
