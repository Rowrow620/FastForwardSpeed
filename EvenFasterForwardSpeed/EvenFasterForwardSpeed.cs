using System;
using System.Reflection;
using Harmony;
using LobotomyBaseMod;
using UnityEngine;

namespace EvenFasterForwardSpeed
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            try
            {
                ModDebug.Log("[EvenFasterForwardSpeed] Initializing Even Faster-Forward Speed Multipliers Mod (1x, 8x, 16x)...");
                HarmonyInstance harmony = HarmonyInstance.Create("EvenFasterForwardSpeed");

                MethodInfo originalUpdateGameSpeed = typeof(GameManager).GetMethod("UpdateGameSpeed", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                MethodInfo postfixUpdateGameSpeed = typeof(Harmony_Patch).GetMethod("UpdateGameSpeed_Postfix", BindingFlags.Static | BindingFlags.Public);
                harmony.Patch(originalUpdateGameSpeed, null, new HarmonyMethod(postfixUpdateGameSpeed));

                ModDebug.Log("[EvenFasterForwardSpeed] Even Faster-Forward Speed Multipliers successfully loaded!");
            }
            catch (Exception ex)
            {
                ModDebug.Log("[EvenFasterForwardSpeed] Failed to load patches: " + ex.Message + "\n" + ex.StackTrace);
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
                Time.timeScale = 8f;
                Time.fixedDeltaTime = 0.16f;
            }
            else if (__instance.gameSpeedLevel == 3)
            {
                Time.timeScale = 16f;
                Time.fixedDeltaTime = 0.32f;
            }
        }
    }
}
