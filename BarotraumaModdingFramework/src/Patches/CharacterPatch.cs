using HarmonyLib;
using Barotrauma;
using System.Drawing;

namespace BarotraumaModdingFramework.Patches;

[HarmonyPatch(typeof(Character))]
[HarmonyPatch(nameof(Character.SpeechBubble))]
public class SpeechBubblePatch
{
    public static void Prefix(object __instance, ref Character character, ref float lifeTime, ref Color color, ref string text)
    {
        
    }

    public static void Postfix(Character character)
    {
        
    }    
}


public class CharacterPatch
{
}