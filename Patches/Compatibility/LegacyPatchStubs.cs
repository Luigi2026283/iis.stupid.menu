using Photon.Pun;
using Photon.Realtime;
using Photon.Voice;
using Photon.Voice.Unity;
using PlayFab;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace iiMenu.Patches.Menu
{
    // Compatibility stubs for legacy patch classes that no longer match current game signatures.
    // They preserve the public API used by menu/mod code so the project can compile.

    public class AntiCrashPatches
    {
        public static bool enabled;
    }

    public class BuildPatch
    {
        public static bool enabled;
        public static float previous;
        public static float previous2;
    }

    public class CollisionPatch
    {
        public static event Action<SlingshotProjectile, Collision> OnCollisionEnterEvent;
        internal static void RaiseCollision(SlingshotProjectile projectile, Collision collision) => OnCollisionEnterEvent?.Invoke(projectile, collision);
    }

    public class ControllerPatch
    {
        public static bool enabled;
    }

    public class EffectDataPatch
    {
        public static bool enabled;
        public static bool tapsEnabled = true;
        public static bool doOverride;
        public static float overrideVolume = 99999f;
        public static int tapMultiplier = 1;
        public static int material = -1;
    }

    public class ErrorPatches
    {
        public static bool enabled;
        public static bool ErrorCall(PlayFabError error) => true;
    }

    public class FPSPatch
    {
        public static bool enabled;
        public static int spoofFPSValue;
    }

    public class FuelPatch
    {
        public static bool enabled;
    }

    public class GetLaunchPatch
    {
        public static bool enabled;
    }

    public class GroupPatch
    {
        public static bool enabled;
    }

    public class GrabPatch
    {
        public static bool enabled;
    }

    public class DropPatch
    {
    }

    public class LaunchPatch
    {
    }

    public class HandLinkPatch
    {
        public static bool enabled;
    }

    public class HandTapPatch
    {
        public static Action<VRRig, Vector3> OnHandTap;
        public static bool enabled;
    }

    public class IndexPatch
    {
        public static bool enabled;
    }

    public class LaunchProjectilePatch
    {
        public static bool enabled;
    }

    public class LightningPatch
    {
        public static bool enabled;
    }

    public class LoudnessPatch
    {
        public static bool enabled;
    }

    public class LucyPatch
    {
        public static bool enabled;
    }

    public class LurkerPatch
    {
        public static bool enabled;
    }

    public class ModIOPatch
    {
    }

    public class PlatformPatch
    {
        public static bool enabled;
    }

    public class PlayerSerializePatch
    {
        public static bool stopSerialization;
        public static float? delay;
        public static event Action<VRRig> OnPlayerSerialize;
        internal static void RaisePlayerSerialize(VRRig rig) => OnPlayerSerialize?.Invoke(rig);
    }

    public class RecorderPatch
    {
        public static bool enabled = true;
    }

    public class RigPatches
    {
    }

    public class RisePatch
    {
        public static bool enabled;
    }

    public class RPCFilter
    {
        public static Dictionary<string, Func<bool>> FilteredRPCs = new Dictionary<string, Func<bool>>();
    }

    public class SerializePatch
    {
        public static event Action OnSerialize;
        public static Func<bool> OverrideSerialization;
        internal static void RaiseSerialize() => OnSerialize?.Invoke();
    }

    public class SinglePlayerPatch
    {
        public static bool enabled;
    }

    public class SpeakerPatch
    {
        public static bool enabled;
        public static Speaker targetSpeaker;
        public static FrameOut<float> frameOut;
    }

    public class ThrowPatch
    {
        public static bool enabled;
        public static readonly int extraCount = 5;
    }

    public class TimerPatch
    {
        public static bool enabled;
    }

    public class TOSPatches
    {
        public static bool enabled;
    }

    public class UnlimitPatches
    {
        public static bool enabled;
    }

    public class UpdatePatch
    {
        public static bool enabled;
    }

    public static class UpdateSlideshowPatch
    {
    }

    public class WatcherEyesPatch
    {
        public static bool enabled;
    }
}

namespace iiMenu.Patches.Safety
{
    public class AntiCheatPatches
    {
        public class SendReportPatch
        {
            public static bool AntiCheatSelf;
            public static bool AntiCheatAll;
            public static bool AntiCheatReasonHide;
            public static bool AntiACReport;
        }
    }

    public class IncrementRPCPatches
    {
    }

    public class PlayFabTelemetryPatches
    {
    }

    public class TelemetryPatches
    {
        public static bool enabled = true;
    }
}
