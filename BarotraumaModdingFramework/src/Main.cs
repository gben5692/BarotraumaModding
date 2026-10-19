using System.Runtime.InteropServices;
using HarmonyLib;

namespace BarotraumaModdingFramework;

internal class Main
{
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();


    private static ModLoader? modLoader;

    public static void Initialize()
    {
        AllocConsole();

        Console.Title = $"BarotraumaModdingFramework. V1.0.0";

        var standardOutput = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        var standardInput = new StreamReader(Console.OpenStandardInput());

        Console.SetOut(standardOutput);
        Console.SetIn(standardInput);

        PatchAll();

        modLoader = new();
        modLoader.Initialize();

        Task.Run(ConsoleCommands);
    }

    public static void ConsoleCommands()
    {
        Console.WriteLine("For commands type -help for a list of commands");

        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }

            switch (input)
            {
                case "-help":
                    Console.WriteLine("Available Commands: -help, -unload, -reload, -list");
                    break;

                case "-unload":
                    modLoader?.UnloadPlugins();
                    break;

                case "-reload":
                    modLoader?.ReloadPlugins();
                    break;

                case "-list":
                    modLoader?.ListPlugins();
                    break;
            }
        }
    }

    public static void PatchAll()
    {
        Console.WriteLine("Patching ...");

        var harmony = new Harmony("BarotraumaModdingFramework");
        harmony.PatchAll();

        Console.WriteLine("Patching Done!");
    }
}
