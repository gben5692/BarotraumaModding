

using Barotrauma;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Handler.Player;

public class SendingSpeechBubbleEventArgs(Character character, float lifeTime, Color color, string text)
{
    public Character Character {get;} = character;
    public float LifeTime {get; set;} = lifeTime;
    public Color Color {get; set;} = color;
    public string Text {get; set;} = text;
}