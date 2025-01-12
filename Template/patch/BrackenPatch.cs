using HarmonyLib;

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
