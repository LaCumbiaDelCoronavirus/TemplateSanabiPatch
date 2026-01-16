using System.Reflection;
using HarmonyLib;


#pragma warning disable CA1050 // Declare types in namespace
// Do not change signature or name or namespace
public static class PatchEntry
#pragma warning restore CA1050 // Declare types in namespace
{
    // Do not change signature or name or namespace
    public static void Entry(Dictionary<string, Assembly?> assemblyDictionary)
    {
        if (!assemblyDictionary.TryGetValue("Content.Client", out _))
            return;

        new Harmony("sanabi.ext.dpatch").PatchAll(Assembly.GetExecutingAssembly());
    }
}
