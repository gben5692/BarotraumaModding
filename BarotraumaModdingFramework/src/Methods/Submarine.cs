

namespace BarotraumaModdingFramework.Methods;

public class Submarine(Barotrauma.Submarine submarine)
{
    internal readonly Barotrauma.Submarine BarotraumaSubmarine = submarine;

    /// <summary>
    /// If the submarine is an respawn shuttle
    /// </summary>
    public bool IsRespawnShuttle => BarotraumaSubmarine.IsRespawnShuttle;

    /// <summary>
    /// Idk honestly
    /// </summary>
    public bool IsAboveLevel => BarotraumaSubmarine.IsAboveLevel;
}