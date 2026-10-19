using System.Reflection;

namespace BarotraumaModdingFramework.Debugging;

/// <summary>
/// This class allows the user to debug their game
/// </summary>
public class Print
{
    public enum Level
    {
        None,
        Info,
        Debug,
        Warning,
        Error
    }

    public static void Info(string message)
    {
        PrepareLog(Level.Info   , message, Assembly.GetCallingAssembly());
    }

    public static void Debug(string message)
    {
        PrepareLog(Level.Debug, message, Assembly.GetCallingAssembly());
    }

    public static void Warning(string message)
    {
        PrepareLog(Level.Warning, message, Assembly.GetCallingAssembly());
    }

    public static void Error(string message)
    {
        PrepareLog(Level.Error, message, Assembly.GetCallingAssembly());
    }

    private static void PrepareLog(Level level, string message, Assembly callingAssembly)
    {
        var assemblyName = callingAssembly.GetName().Name ?? "UnknownMod";

        if (string.IsNullOrWhiteSpace(message))
        {
            Log(Level.None, $"You had either null or whitespaces in the Print.{level}, Please fix that!", assemblyName);
        }
        else
        {
            Log(level, message, assemblyName);
        }
    }

    private static void Log(Level level, string message, string assemblyName)
    {
        
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"[{DateTime.Now:HH:mm:ss:fff}]");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("[");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{assemblyName}");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("]");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("[");

        Console.ForegroundColor = level switch
        {
            Level.Info => ConsoleColor.Cyan,
            Level.Debug => ConsoleColor.Green,
            Level.Warning => ConsoleColor.Yellow,
            Level.Error => ConsoleColor.Red,
            Level.None => ConsoleColor.Magenta,
            _ => ConsoleColor.White
        };
        Console.Write(level);

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("] ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);

        Console.ResetColor();

    }
}