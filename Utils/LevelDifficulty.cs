
using GamePrototype.Combat;
using GamePrototype.Game;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;
using GamePrototype.Utils;
using System.Reflection;
using System.Xml.Linq;

namespace levelDifficulty
{
    public class LevelDifficulty : UnitFactoryDemo
    {
        private Unit Player;
        readonly Dictionary<uint, uint> weapon = new Dictionary<uint, uint>();
        public void difficulty()
        {
            Console.WriteLine($"level {level.Easy} = {(int)level.Easy} (OR) {level.Hard} = {(int)level.Hard}");
            if (Enum.TryParse<level>(Console.ReadLine(), out var Level))
            {
                Console.WriteLine($"difficulty level - {Level}");
            }
            switch (Level)
            {
                case level.Easy:
                    {
                        Console.WriteLine("Enter your name");
                        _player = new Player(Console.ReadLine(), 30, 30, 6);
                        _weapon = new Weapon(10, 15, "Weapon");
                        _armour = new Armour(10, 15, "Armour");
                        _weaponrange = new RangeWeapon(12, 12, "Range Weapon");
                        _obsidianarmor = new ObsidianArmour(12, 12, "Obsidian Armor");
                    }
                    break;
                case level.Hard:
                    {
                        Console.WriteLine("Enter your name");
                        _player = new Player(Console.ReadLine(), 25, 25, 4);
                        _weapon = new Weapon(5, 10, "Weapon");
                        _armour = new Armour(5, 10, "Armour");
                        _weaponrange = new RangeWeapon(10, 10, "Range Weapon");
                        _obsidianarmor = new ObsidianArmour(10, 10, "Obsidian Armor");
                    }
                    break;
            }
        }
    }
}