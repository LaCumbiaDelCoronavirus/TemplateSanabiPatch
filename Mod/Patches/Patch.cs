using System.Reflection;
using HarmonyLib;

namespace Mod.Patches;

[HarmonyPatch]
internal static class Patch
{
    [HarmonyTargetMethod]
    private static MethodInfo TargetMethod()
    {
        return AccessTools.Method(AccessTools.TypeByName("Robust.Client.Console.ClientConsoleHost"), "CanExecute");
    }

    [HarmonyPostfix]
    private static void Postfix(ref bool __result) => __result = true;
}
