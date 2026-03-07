/*
 * ii's Stupid Menu  Utilities/RigUtilities.cs
 * A mod menu for Gorilla Tag with over 1000+ mods
 *
 * Copyright (C) 2026  Goldentrophy Software
 * https://github.com/iiDk-the-actual/iis.Stupid.Menu
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using iiMenu.Extensions;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

namespace iiMenu.Utilities
{
    public static class RigUtilities
    {
        private static readonly BindingFlags AnyMember = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        public static VRRig GetVRRigFromPlayer(NetPlayer p) =>
            GorillaGameManager.StaticFindRigForPlayer(p);

        public static NetPlayer GetPlayerFromVRRig(VRRig p) =>
            p == null ? null : p.Creator ?? ResolveOwnerFromRig(p);

        private static NetPlayer ResolveOwnerFromRig(VRRig rig)
        {
            try
            {
                GameObject ownerObject = ResolveRigSerializerGameObject(rig) ?? rig.gameObject;
                int ownerId = NetworkSystem.Instance.GetOwningPlayerID(ownerObject);
                return NetworkSystem.Instance.GetPlayer(ownerId);
            }
            catch
            {
                return null;
            }
        }

        private static GameObject ResolveRigSerializerGameObject(VRRig rig)
        {
            if (rig == null)
                return null;

            try
            {
                object serializer = rig.GetType().GetField("rigSerializer", AnyMember)?.GetValue(rig) ??
                                    rig.GetType().GetProperty("rigSerializer", AnyMember)?.GetValue(rig, null);
                if (serializer is Component component)
                    return component.gameObject;
            }
            catch
            {
            }

            return null;
        }

        public static NetPlayer GetPlayerFromID(string id) =>
            PhotonNetwork.PlayerList.FirstOrDefault(player => player.UserId == id);

        public static Player NetPlayerToPlayer(NetPlayer p) =>
            p.GetPlayerRef();

        public static Player GetRandomPlayer(bool includeSelf) =>
            includeSelf ?
            PhotonNetwork.PlayerList[Random.Range(0, PhotonNetwork.PlayerList.Length)] :
            PhotonNetwork.PlayerListOthers[Random.Range(0, PhotonNetwork.PlayerListOthers.Length)];

        private static VRRig rigTarget;
        private static float rigTargetChange;
        public static VRRig GetTargetPlayer(float targetChangeDelay = 1f)
        {
            if (!(Time.time > rigTargetChange) && rigTarget.Active()) return rigTarget;
            rigTargetChange = Time.time + targetChangeDelay;
            rigTarget = GetRandomVRRig(false);

            return rigTarget;
        }

        public static VRRig GetRandomVRRig(bool includeSelf) =>
            GetVRRigFromPlayer(GetRandomPlayer(includeSelf));

        public static NetworkView GetNetworkViewFromVRRig(VRRig p) =>
            ResolveNetworkView(p);

        private static NetworkView ResolveNetworkView(VRRig rig)
        {
            if (rig == null)
                return null;

            try
            {
                object netView = rig.GetType().GetField("netView", AnyMember)?.GetValue(rig) ??
                                 rig.GetType().GetProperty("netView", AnyMember)?.GetValue(rig, null);
                if (netView is NetworkView view)
                    return view;
            }
            catch
            {
            }

            return rig.GetComponent<NetworkView>();
        }

        public static PhotonView GetPhotonViewFromVRRig(VRRig p) =>
            GetNetworkViewFromVRRig(p)?.GetView ?? p?.GetComponent<PhotonView>();

        public static List<VRRig> GetRigs(this GorillaParent parent)
        {
            if (parent == null)
                return new List<VRRig>();

            if (TryReadRigList(parent, "vrrigs", out List<VRRig> rigs))
                return rigs;
            if (TryReadRigList(parent, "allVRRigs", out rigs))
                return rigs;
            if (TryReadRigList(parent, "allVrrigs", out rigs))
                return rigs;

            return UnityEngine.Object.FindObjectsByType<VRRig>(FindObjectsSortMode.None).ToList();
        }

        private static bool TryReadRigList(GorillaParent parent, string memberName, out List<VRRig> rigs)
        {
            rigs = null;
            try
            {
                object value = parent.GetType().GetField(memberName, AnyMember)?.GetValue(parent) ??
                               parent.GetType().GetProperty(memberName, AnyMember)?.GetValue(parent, null);
                if (value is List<VRRig> list)
                {
                    rigs = list;
                    return true;
                }

                if (value is VRRig[] array)
                {
                    rigs = array.ToList();
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        public static VRRig GetClosestVRRig() =>
            VRRig.LocalRig.GetClosest();

        public static readonly Dictionary<string, float> waitingForCreationDate = new Dictionary<string, float>();
        public static readonly Dictionary<string, string> creationDateCache = new Dictionary<string, string>();
        public static string GetCreationDate(string input, Action<string> onTranslated = null, string format = "MMMM dd, yyyy h:mm tt")
        {
            if (creationDateCache.TryGetValue(input, out string date))
                return date;
            if (!waitingForCreationDate.ContainsKey(input))
            {
                waitingForCreationDate[input] = Time.time + 10f;
                GetCreationCoroutine(input, onTranslated, format);
            }
            else
            {
                if (!(Time.time > waitingForCreationDate[input])) return "Loading...";
                waitingForCreationDate[input] = Time.time + 10f;
                GetCreationCoroutine(input, onTranslated, format);
            }

            return "Loading...";
        }

        public static void GetCreationCoroutine(string userId, Action<string> onTranslated = null, string format = "MMMM dd, yyyy h:mm tt")
        {
            if (creationDateCache.TryGetValue(userId, out string date))
            {
                onTranslated?.Invoke(date);
                return;
            }

            PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest { PlayFabId = userId }, delegate (GetAccountInfoResult result) // Who designed this
            {
                string creationDate = result.AccountInfo.Created.ToString(format);
                creationDateCache[userId] = creationDate;

                onTranslated?.Invoke(creationDate);
            }, delegate { creationDateCache[userId] = "Error"; onTranslated?.Invoke("Error"); });
        }
    }
}
