using Barotrauma;
using BarotraumaModdingFramework.Handler.World;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Events;

public class World
{
    // public static event BarotraumaEvent<LoadMonsterEventArgs>? LoadMonster;
    // internal static void InvokeLoadMonster(CharacterPrefab monsterPrefab, XElement element, Submarine submarine) => LoadMonster?.Invoke(new(monsterPrefab, element, submarine));

    // public static event BarotraumaEvent<LoadedMonsterEventArgs>? LoadedMonster;
    // internal static void InvokeLoadedMonster(Character monsterPrefab, XElement element, Submarine submarine) => LoadedMonster?.Invoke(new(monsterPrefab, element, submarine));

    public static event BarotraumaEvent<SendingSpeechBubbleEventArgs>? SendingSpeechBubble;
    internal static void InvokeSendingSpeechBubble(Character character, float lifeTime, Color color, string text) => SendingSpeechBubble?.Invoke(new(character, lifeTime, color, text));
    
    public static event BarotraumaEvent<SentSpeechBubbleEventArgs>? SentSpeechBubble;
    internal static void InvokeSentSpeechBubble(Character character, float lifeTime, Color color, string text) => SentSpeechBubble?.Invoke(new(character, lifeTime, color, text));

}
