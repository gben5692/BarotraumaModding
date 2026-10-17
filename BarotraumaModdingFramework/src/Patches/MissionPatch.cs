using HarmonyLib;
using Barotrauma;
using System.Xml.Linq;
using BarotraumaModdingFramework.Events;
using System.Runtime.CompilerServices;

namespace BarotraumaModdingFramework.Patches;

// [HarmonyPatch]
// public class LoadMonsterPatch
// {
//     [HarmonyReversePatch]
//     [HarmonyPatch(typeof(Mission), nameof(Mission.LoadMonster))]
//     [MethodImpl(MethodImplOptions.NoInlining)]
//     static Character? LoadMonsterDummy(Mission instance, CharacterPrefab monsterPrefab, XElement element, Submarine submarine) => null;

//     static void Prefix(Mission __instance, CharacterPrefab monsterPrefab, XElement element, Submarine submarine)
//     {
//         var character = LoadMonsterDummy(__instance, monsterPrefab, element, submarine);
//     }
// }