using System.Reflection;
using System.Runtime.InteropServices;
using HarmonyLib;


namespace BarotraumaModdingFramework;

public class Main
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
    }

    public static void PatchAll()
    {
        Console.WriteLine("Patching ...");

        var harmony = new Harmony("BarotraumaModdingFramework");
        harmony.PatchAll();

        Console.WriteLine("Patching Done!");
    }
}
