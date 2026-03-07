/*
 * ii's Stupid Menu  Patches/Menu/TitleDataJsonPatch.cs
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
using System.Reflection;

namespace iiMenu.Patches.Menu
{
    internal static class TitleDataJsonSanitizer
    {
        internal static string TrimToSingleRoot(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            int start = 0;
            while (start < input.Length && char.IsWhiteSpace(input[start]))
                start++;

            if (start >= input.Length)
                return input;

            char opener = input[start];
            if (opener != '{' && opener != '[')
                return input;

            int depth = 0;
            bool inString = false;
            bool escaped = false;

            for (int i = start; i < input.Length; i++)
            {
                char c = input[i];

                if (inString)
                {
                    if (escaped)
                    {
                        escaped = false;
                        continue;
                    }

                    if (c == '\\')
                    {
                        escaped = true;
                        continue;
                    }

                    if (c == '"')
                        inString = false;

                    continue;
                }

                if (c == '"')
                {
                    inString = true;
                    continue;
                }

                if (c == '{' || c == '[')
                    depth++;
                else if (c == '}' || c == ']')
                {
                    depth--;
                    if (depth == 0)
                        return input.Substring(start, i - start + 1);
                }
            }

            return input;
        }
    }

    [HarmonyPatch]
    internal static class KIDManagerGetPhasePatch
    {
        private static MethodBase TargetMethod() => AccessTools.Method("KIDManager:GetPhase", new[] { typeof(string) });

        private static void Prefix(ref string jsonTxt)
        {
            jsonTxt = TitleDataJsonSanitizer.TrimToSingleRoot(jsonTxt);
        }
    }

    [HarmonyPatch]
    internal static class KIDManagerGetNewPlayerDateTimePatch
    {
        private static MethodBase TargetMethod() => AccessTools.Method("KIDManager:GetNewPlayerDateTime", new[] { typeof(string) });

        private static void Prefix(ref string jsonTxt)
        {
            jsonTxt = TitleDataJsonSanitizer.TrimToSingleRoot(jsonTxt);
        }
    }

    [HarmonyPatch]
    internal static class KIDManagerGetIsEnabledPatch
    {
        private static MethodBase TargetMethod() => AccessTools.Method("KIDManager:GetIsEnabled", new[] { typeof(string) });

        private static void Prefix(ref string jsonTxt)
        {
            jsonTxt = TitleDataJsonSanitizer.TrimToSingleRoot(jsonTxt);
        }
    }

    [HarmonyPatch]
    internal static class BundleListFromJsonPatch
    {
        private static MethodBase TargetMethod() => AccessTools.Method("BundleList:FromJson", new[] { typeof(string) });

        private static void Prefix(ref string jsonString)
        {
            jsonString = TitleDataJsonSanitizer.TrimToSingleRoot(jsonString);
        }
    }
}
