using System.Reflection;
using HarmonyLib;

// This is the entry point of the mod for the launcher.

#pragma warning disable CA1050 // Declare types in namespace
// Do not change signature or name or namespace; this is found via reflection
public static class PatchEntry
#pragma warning restore CA1050 // Declare types in namespace
{
    // Do not change signature or name or namespace; this is found via reflection
    public static void Entry(Dictionary<string, Assembly?> assemblyDictionary)
    {
        if (!assemblyDictionary.TryGetValue("Content.Client", out _))
            return;

        new Harmony($"sanabi.ext.{new Guid()}").PatchAll(Assembly.GetExecutingAssembly());
    }
}
