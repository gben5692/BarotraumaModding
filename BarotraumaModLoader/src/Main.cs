using System.Runtime.InteropServices;

namespace BarotraumaModLoader;

partial class Main
{
    enum DllReasonForCall 
    {
        DLL_PROCESS_ATTACH = 1,
        DLL_PROCESS_DETACH = 0,
        DLL_THREAD_ATTACH = 2,
        DLL_THREAD_DETACH = 3,
    }

    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool AllocConsole();

    [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial nint LoadLibraryW(string lpLibFileName);

    private static readonly string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BarotraumaModdingFramework.dll");


    [UnmanagedCallersOnly(EntryPoint = "DllMain")]
    public static bool DllMain(nint hinstDll, int fdwReason, nint lpvReserved) // default entry point
    {
        switch (fdwReason)
        {
            case (int)DllReasonForCall.DLL_PROCESS_ATTACH:
                Initialize();
                break;

            case (int)DllReasonForCall.DLL_PROCESS_DETACH:
                break;

            case (int)DllReasonForCall.DLL_THREAD_ATTACH:
                break;

            case (int)DllReasonForCall.DLL_THREAD_DETACH:
                break;
        }

        return true;
    }

    public static void Initialize()
    {
        CreateConsole();
        LoadBarotraumaModdingFramework();
    }

    public static void CreateConsole()
    {
        AllocConsole();

        Thread thread = new(LoadBarotraumaModdingFramework);
        thread.Start();
    }

    public static void LoadBarotraumaModdingFramework()
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in trying to load the modding framework: {ex}");
        }
    }
}
