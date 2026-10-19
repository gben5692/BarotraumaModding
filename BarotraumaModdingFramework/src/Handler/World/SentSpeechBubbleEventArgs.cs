using BarotraumaModdingFramework.Methods;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Handler.World;

public class SentSpeechBubbleEventArgs(Barotrauma.Character character, float lifeTime, Color color, string text)
{
    public Character Character {get;} = new(character);
    public float LifeTime {get; set;} = lifeTime;
    public Color Color {get; set;} = color;
    public string Text {get; set;} = text;
}