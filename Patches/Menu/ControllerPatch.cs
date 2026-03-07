/*
 * ii's Stupid Menu  Patches/Menu/ControllerPatch.cs
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

using HarmonyLib;
using System;
using System.Linq;
using System.Reflection;

namespace iiMenu.Patches.Menu
{
    [HarmonyPatch(typeof(ConnectedControllerHandler))]
    public class ControllerPatch
    {
        public static bool enabled;
        
        private static MethodBase TargetMethod()
        {
            Type handlerType = typeof(ConnectedControllerHandler);
            string[] candidates =
            {
                "DeviceDisconnected",
                "OnDeviceDisconnected",
                "HandleDeviceDisconnected",
                "DeviceConnectionChanged"
            };

            foreach (string candidate in candidates)
            {
                MethodInfo method = AccessTools.Method(handlerType, candidate);
                if (method != null)
                    return method;
            }

            return handlerType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .FirstOrDefault(method =>
                    method.Name.Contains("Disconnected") ||
                    method.Name.Contains("ConnectionChanged"));
        }

        public static bool Prefix() => !enabled;
    }
}
