

using BarotraumaModdingFramework.Patches;

namespace BarotraumaModdingFramework;

/// <summary>
/// This contains list of all events tied to player
/// </summary>
public class Player
{
    //public static event BarotraumaEvent<PlayerSpawnedEventArgs>? Spawned;
}

/// <summary>
/// This is the base for every event
/// </summary>
/// <typeparam name="T">The event handler</typeparam>
/// <param name="ev">The event methods</param>
public delegate void BarotraumaEvent<T>(T ev);