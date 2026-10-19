using Barotrauma;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Methods;

public class Character(Barotrauma.Character character)
{
    internal readonly Barotrauma.Character BarotraumaCharacter = character;

    /// <summary>
    /// This is the position of the character
    /// </summary>
    public Vector2 Position => BarotraumaCharacter.Position;

    /// <summary>
    /// The name of the character
    /// </summary>
    public string Name => BarotraumaCharacter.Name;

    /// <summary>
    /// If the character is handcuffed
    /// </summary>
    public bool IsHandcuffed => BarotraumaCharacter.IsHandcuffed;

    /// <summary>
    /// If the character is husk
    /// </summary>
    public bool IsHusk => BarotraumaCharacter.IsHusk;

    /// <summary>
    /// If the character is security
    /// </summary>
    public bool IsSecurity => BarotraumaCharacter.IsSecurity;

    /// <summary>
    /// If the character is acting offensively
    /// </summary>
    public bool IsActingOffensively => BarotraumaCharacter.IsActingOffensively;

    /// <summary>
    /// If the character is male
    /// </summary>
    public bool IsMale => BarotraumaCharacter.IsMale;

    /// <summary>
    /// If the character is female
    /// </summary>
    public bool IsFemale => BarotraumaCharacter.IsFemale;

    /// <summary>
    /// If the character is a criminal
    /// </summary>
    public bool IsCriminal => BarotraumaCharacter.IsCriminal;

    /// <summary>
    /// If the character is climbing
    /// </summary>
    public bool IsClimbing => BarotraumaCharacter.IsClimbing;

    /// <summary>
    /// If the character is a captain
    /// </summary>
    public bool IsCaptain => BarotraumaCharacter.IsCaptain;


    /// <summary>
    /// If the character is an assistant
    /// </summary>
    public bool IsAssistant => BarotraumaCharacter.IsAssistant;

    /// <summary>
    /// If an ai is controlling the character
    /// </summary>
    public bool IsAIControlled => BarotraumaCharacter.IsAIControlled;

    /// <summary>
    /// If the character is dead
    /// </summary>
    public bool IsDead => BarotraumaCharacter.IsDead;

    /// <summary>
    /// Is the character a bot
    /// </summary>
    public bool IsBot => BarotraumaCharacter.IsBot;

    /// <summary>
    /// The health of the character
    /// </summary>
    public float Health => BarotraumaCharacter.Health;

    /// <summary>
    /// If the character was a friendly before turning hostile
    /// </summary>
    public bool IsFriendlyNPCTurnedHostile => BarotraumaCharacter.IsFriendlyNPCTurnedHostile;

    /// <summary>
    /// If the character is a machine
    /// </summary>
    public bool IsMachine => BarotraumaCharacter.IsMachine;

    /// <summary>
    /// If the character is containable
    /// </summary>
    public bool IsContainable => BarotraumaCharacter.IsContainable;

    /// <summary>
    /// If the character is dismissed
    /// </summary>
    public bool IsDismissed => BarotraumaCharacter.IsDismissed;

    /// <summary>
    /// If the character is in a player submarine
    /// </summary>
    public bool IsInPlayerSubmarine => BarotraumaCharacter.IsInPlayerSub;

    /// <summary>
    /// If the character is in a friendly submarine
    /// </summary>
    public bool IsInFriendlySubmarine => BarotraumaCharacter.IsInFriendlySub;


    /// <summary>
    /// This creates an character
    /// </summary>
    /// <param name="speciesName">The species human, husk or something else</param>
    /// <param name="position">The position for the character to spawn</param>
    /// <param name="seed">The seed i have no idea what to assign this to</param>
    /// <returns>The newly created character</returns>
    public static Character Create(string speciesName, Vector2 position, string seed)
    {
        var character = Barotrauma.Character.Create(speciesName, position, seed);
        return new Character(character);
    }

    /// <summary>
    /// This turns the character into a husk
    /// </summary>
    public void TurnIntoHusk() => BarotraumaCharacter.TurnIntoHusk();

    /// <summary>
    /// This despawns the character
    /// </summary>
    public void Despawn() => BarotraumaCharacter.Despawn();

    /// <summary>
    /// This kills the character
    /// </summary>
    /// <param name="causeOfDeath">The cause of death</param>
    /// <param name="affliction">And the affliction</param>
    public void Kill(CauseOfDeathType causeOfDeath, Affliction affliction) => BarotraumaCharacter.Kill(causeOfDeath, affliction);

    /// <summary>
    /// This makes a text above the character
    /// </summary>
    /// <param name="text">The text</param>
    /// <param name="color">The color</param>
    /// <param name="playSound">If it should play sound</param>
    /// <param name="lifeTime">How long it should last</param>
    public void AddMessage(string text, Color color, bool playSound, float lifeTime) => BarotraumaCharacter.AddMessage(text, color, playSound, default, null, lifeTime);
}