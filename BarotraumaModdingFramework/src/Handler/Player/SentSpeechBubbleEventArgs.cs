using Barotrauma;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Handler.Player;

public class SentSpeechBubbleEventArgs(Character character, float lifeTime, Color color, string text)
{
    public Character Character {get;} = character;
    public float LifeTime {get; set;} = lifeTime;
    Color Color {get; set;} = color;
    public string Text {get; set;} = text;
}