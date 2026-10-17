using HarmonyLib;
using Barotrauma;
using Microsoft.Xna.Framework;
using BarotraumaModdingFramework.Events;

namespace BarotraumaModdingFramework.Patches;

[HarmonyPatch(typeof(Character.SpeechBubble), MethodType.Constructor)]
[HarmonyPatch([typeof(Character), typeof(float), typeof(Color), typeof(string)])]
public class SpeechBubblePatch
{
    public static void Prefix(ref Character character, ref float lifeTime, ref Color color, ref string text)
    {
        // if (character == GameMain.Client.Character)
        // {
        //     Player.InvokeSendingMessage(character, lifeTime, color, text);
        // }

        // if (character == Character.controlled)
        // {
        //     Player.InvokeSendingSpeechBubble(character, lifeTime, color, text);
        // }

        // World.InvokeSendingSpeechBubble(character, lifeTime, color, text);
    }

    public static void Postfix(Character character, float lifeTime, Color color, string text)
    {
        // if (character == GameMain.Client.Character)
        // {
        //     Player.InvokeSentMessage(character, lifeTime, color, text);
        // }

        // if (character == Character.controlled)
        // {
        //     Player.InvokeSentSpeechBubble(character, lifeTime, color, text);
        // }

        World.InvokeSentSpeechBubble(character, lifeTime, color, text);
    }    
}