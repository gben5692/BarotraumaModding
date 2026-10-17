using System.Xml.Linq;
using Barotrauma;

namespace BarotraumaModdingFramework.Handler;

public class LoadedMonsterEventArgs(Character monsterPrefab, XElement element, Submarine submarine)
{
    public Character MonsterPrefab {get; set;} = monsterPrefab;
    public XElement Element {get; set;} = element;
    public Submarine Submarine {get;} = submarine;
}