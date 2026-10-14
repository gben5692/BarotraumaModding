using HarmonyLib;


namespace BarotraumaModdingFramework;

public class Main // how can we call this?
{

    public static void Initialize()
    {
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
