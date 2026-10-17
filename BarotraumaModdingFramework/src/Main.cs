using System.Runtime.InteropServices;
using HarmonyLib;

namespace BarotraumaModdingFramework;

internal class Main
{
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    public static void Initialize()
    {
        AllocConsole();

        var standardOutput = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        Console.SetOut(standardOutput);

        PatchAll();
        
        ModLoader modLoader = new();
        modLoader.Initialize();
    }

    public static void PatchAll()
    {
        Console.WriteLine("Patching ...");

        var harmony = new Harmony("BarotraumaModdingFramework");
        harmony.PatchAll();

        Console.WriteLine("Patching Done!");
    }
}
