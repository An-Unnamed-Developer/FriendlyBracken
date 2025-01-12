using HarmonyLib;
using UnityEngine;

namespace LoganC.patch;

/// <summary>
/// Patch to modify the behavior of the ship lights.
/// </summary>
[HarmonyPatch(typeof(FlowermanAI))]
public class BrackenPatch
{
    [HarmonyPatch(nameof(FlowermanAI.AddToAngerMeter))]
    [HarmonyPrefix]
    private static bool AddToAngerMeter(ref FlowermanAI __instance, object[] __args)
    {
        Plugin.Log.LogInfo("Anger meter has increased!");

        return false;
    }
}


[HarmonyPatch(typeof(FlowermanAI))]

public class BrackenPatch2
{
    [HarmonyPatch(nameof(FlowermanAI.KillPlayerAnimationServerRpc))]
    [HarmonyPrefix]
    private static bool KillPlayerAnimationServerRpc(ref FlowermanAI __instance, object[] __args)
    {
        Plugin.Log.LogInfo("Help me.");
        return false;
    }
    [HarmonyPatch(nameof(FlowermanAI.KillPlayerAnimationClientRpc))]
    [HarmonyPrefix]
    private static bool KillPlayerAnimationClientRpc(ref FlowermanAI __instance, object[] __args)
    {
        Plugin.Log.LogInfo("Help me. Version 2");
        return false;
    }

}
