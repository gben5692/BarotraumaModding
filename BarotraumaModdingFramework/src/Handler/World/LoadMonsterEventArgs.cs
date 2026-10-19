

using System.Xml.Linq;
using Barotrauma;

namespace BarotraumaModdingFramework.Handler.World;

public class LoadMonsterEventArgs(CharacterPrefab monsterPrefab, XElement element, Submarine submarine)
{
    public CharacterPrefab MonsterPrefab {get; set;} = monsterPrefab;
    public XElement Element {get; set;} = element;
    public Submarine Submarine {get;} = submarine;
}