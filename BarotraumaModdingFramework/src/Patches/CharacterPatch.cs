using HarmonyLib;
using Barotrauma;
using Microsoft.Xna.Framework;

namespace BarotraumaModdingFramework.Patches;

[HarmonyPatch(typeof(Character.SpeechBubble))]
[HarmonyPatch(MethodType.Constructor)]
[HarmonyPatch([typeof(Character), typeof(float), typeof(Color), typeof(string)])]
public class SpeechBubblePatch
{
    public static void Prefix(Character character, float lifeTime, Color color, string text)
    {
    }

    public static void Postfix(Character character)
    {
        
    }    
}