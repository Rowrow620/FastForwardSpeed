using System;
using System.Reflection;
using Harmony;
using LobotomyBaseMod;
using UnityEngine;

namespace FastForwardSpeed
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            try
            {
                ModDebug.Log("[FastForwardSpeed] Initializing Fast-Forward Speed Multipliers Mod (1x, 4x, 8x)...");
                HarmonyInstance harmony = HarmonyInstance.Create("FastForwardSpeed");

                MethodInfo originalUpdateGameSpeed = typeof(GameManager).GetMethod("UpdateGameSpeed", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                MethodInfo postfixUpdateGameSpeed = typeof(Harmony_Patch).GetMethod("UpdateGameSpeed_Postfix", BindingFlags.Static | BindingFlags.Public);
                harmony.Patch(originalUpdateGameSpeed, null, new HarmonyMethod(postfixUpdateGameSpeed));

                ModDebug.Log("[FastForwardSpeed] Fast-Forward Speed Multipliers successfully loaded!");
            }
            catch (Exception ex)
            {
                ModDebug.Log("[FastForwardSpeed] Failed to load patches: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        public static void UpdateGameSpeed_Postfix(GameManager __instance)
        {
            if (__instance.state != GameState.PLAYING)
            {
                return;
            }

            if (__instance.gameSpeedLevel == 2)
            {
                Time.timeScale = 4f;
                Time.fixedDeltaTime = 0.08f;
            }
            else if (__instance.gameSpeedLevel == 3)
            {
                Time.timeScale = 8f;
                Time.fixedDeltaTime = 0.16f;
            }
        }
    }
}
