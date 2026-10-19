using System.Reflection;
using System.Runtime.Loader;

namespace BarotraumaModdingFramework;

internal class ModLoader // this class will handle loading plugins from a folder
{

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.

    private readonly string PluginsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
    private readonly List<(AssemblyLoadContext context, Script script)> LoadedPlugins = [];

    public void Initialize()
    {
        Console.WriteLine("Loading Plugins");
        LoadPlugins();
        Console.WriteLine("Plugins Loaded");
    }

    public void LoadPlugins()
    {
        try
        {
            if (!Directory.Exists(PluginsPath))
            {
                Directory.CreateDirectory(PluginsPath);
            }

            var files = Directory.GetFiles(PluginsPath);

            foreach (var file in files)
            {
                if (Path.GetExtension(file) == ".dll")
                {
                    Console.WriteLine("Found Dll File");

                    var dll = new AssemblyLoadContext(Path.GetFileName(file), true);

                    using var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);

                    Assembly assemblyDll = dll.LoadFromStream(fileStream);

                    foreach (var type in assemblyDll.GetTypes())
                    {
                        if (typeof(Script).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                        {
                            var plugin = (Script)Activator.CreateInstance(type);

                            LoadedPlugins.Add((dll, plugin));

                            Console.WriteLine($"Loaded: {plugin?.Name} by {plugin?.Author} v{plugin?.Version}");
                            plugin!.OnEnabled();
                        }
                        
                        dll.Unload();
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error in trying to load plugins with the error: {ex}");
        }
    }

    public void UnloadPlugins()
    {
        try
        {
            Console.WriteLine("Plugins Unloading ...");

            foreach (var (context, script) in LoadedPlugins)
            {
                script.OnDisabled();
                Console.WriteLine($"UnLoaded: {script.Name} by {script.Author} v{script.Version}");
                context.Unload();
            }

            LoadedPlugins.Clear();

            for (int i = 0; i < 2; i++)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            Console.WriteLine("Plugins Unloaded!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in trying to unload plugins with the error: {ex}");
        }
    }

    public void ReloadPlugins()
    {
        Console.WriteLine("Reloading Plugins ...");
        UnloadPlugins();
        LoadPlugins();
        Console.WriteLine("Plugins Reloaded!");
    }

    public void ListPlugins()
    {
        if (LoadedPlugins.Count > 0)
        {
            foreach (var (context, scripts) in LoadedPlugins)
            {
                Console.WriteLine($"Loaded: {scripts?.Name} by {scripts?.Author} v{scripts?.Version}");
            }
        }
        else
        {
            Console.WriteLine("There are no loaded plugins");
        }
    }
}