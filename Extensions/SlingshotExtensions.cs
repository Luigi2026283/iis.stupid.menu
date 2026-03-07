/*
 * ii's Stupid Menu  Extensions/SlingshotExtensions.cs
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

using UnityEngine;
using System.Reflection;

namespace iiMenu.Extensions
{
    public static class SlingshotExtensions
    {
        private static readonly MethodInfo SpawnGrowingSnowballMethod =
            typeof(GrowingSnowballThrowable).GetMethod(
                "SpawnGrowingSnowball",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                null,
                new[] { typeof(Vector3).MakeByRefType(), typeof(float) },
                null
            );

        public static SlingshotProjectile SpawnGrowingSnowball(this GrowingSnowballThrowable snowball, ref Vector3 velocity, float scale)
        {
            if (snowball == null || SpawnGrowingSnowballMethod == null)
                return null;

            object[] args = { velocity, scale };
            SlingshotProjectile projectile = SpawnGrowingSnowballMethod.Invoke(snowball, args) as SlingshotProjectile;

            if (args[0] is Vector3 updatedVelocity)
                velocity = updatedVelocity;

            return projectile;
        }

        public static Vector3 GetTrueLaunchPosition(this Slingshot slingshot) =>
            slingshot.drawingHand.transform.position + 
            (slingshot.centerOrigin.position - slingshot.drawingHand.transform.position).normalized * 
            EquipmentInteractor.instance.grabRadius * 
            Mathf.Abs(slingshot.transform.lossyScale.x);

        public static Vector3 GetNetworkedLaunchVelocity(this Slingshot slingshot)
        {
            float projectileScale = Mathf.Abs(slingshot.transform.lossyScale.x);

            Vector3 baseDirection = slingshot.centerOrigin.position - slingshot.center.position;
            baseDirection /= projectileScale;

            Vector3 fixedDirection = Mathf.Min(slingshot.springConstant * slingshot.maxDraw, baseDirection.magnitude * slingshot.springConstant) * baseDirection.normalized * projectileScale;
            Vector3 averagedVelocity = slingshot.myRig.LatestVelocity();

            return fixedDirection + averagedVelocity;
        }
    }
}
