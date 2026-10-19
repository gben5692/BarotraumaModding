using BarotraumaModdingFramework.Methods;
using System.Xml.Linq;


namespace BarotraumaModdingFramework.Handler.World;

public class LoadedMonsterEventArgs(Character monsterPrefab, XElement element, Barotrauma.Submarine submarine)
{
    public Character MonsterPrefab {get; set;} = monsterPrefab;
    public XElement Element {get; set;} = element;
    public Submarine Submarine {get;} = new(submarine);
}