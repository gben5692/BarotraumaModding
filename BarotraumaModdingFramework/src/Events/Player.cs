using BarotraumaModdingFramework.Patches;
using BarotraumaModdingFramework.Handler;
using Barotrauma;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Events;

/// <summary>
/// This contains list of all events tied to player
/// </summary>
public class Player
{
    //public static event BarotraumaEvent<PlayerSpawnedEventArgs>? Spawned;
    public static event BarotraumaEvent<SendingMessageEventArgs>? SendingMessage;
    internal static void InvokeSendingMessage(Character character, float lifeTime, Color color, string text) => SendingMessage!.Invoke(new(character, lifeTime, color, text));
    
    public static event BarotraumaEvent<SentMessageEventArgs>? SentMessage;
    internal static void InvokeSentMessage(Character character, float lifeTime, Color color, string text) => SentMessage!.Invoke(new(character, lifeTime, color, text));
    
}

/// <summary>
/// This is the base for every event
/// </summary>
/// <typeparam name="T">The event handler</typeparam>
/// <param name="ev">The event methods</param>
public delegate void BarotraumaEvent<T>(T ev);