using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;
using levelDifficulty;

namespace GamePrototype.Utils
{
    public class UnitFactoryDemo
    {
        public static Item _weapon;
        public static Item _weaponrange;
        public static Item _obsidianarmor;
        public static Item _armour;
        public static Unit _player;
        public static Unit _goblin = new Goblin(GameConstants.Goblin, 20, 20, 2);

        public static Unit CreatePlayer()
        {
            var player = _player;
            Console.WriteLine($"level {Armor.armour} = {(int)Armor.armour} (OR) {Armor.obsidianArmour} = {(int)Armor.obsidianArmour}");
            if (Enum.TryParse<Armor>(Console.ReadLine(), out var ArmorVariantable))
            {
                Console.WriteLine($"armor - {ArmorVariantable}");
            }
            switch (ArmorVariantable)
            {
                case Armor.armour:
                    {
                        player.AddItemToInventory(_armour);
                    }
                    break;
                case Armor.obsidianArmour:
                    {
                        player.AddItemToInventory(_obsidianarmor);
                    }
                    break;
            }
            Console.WriteLine($"level {Weapons.weapon} = {(int)Weapons.weapon} (OR) {Weapons.weapoRange} = {(int)Weapons.weapoRange}");
            if (Enum.TryParse<Weapons>(Console.ReadLine(), out var WeaponVariatable))
            {
                Console.WriteLine($"weapon - {WeaponVariatable}");
            }
            switch (WeaponVariatable)
            {
                case Weapons.weapon:
                    {
                        player.AddItemToInventory(_weapon);
                    }
                    break;
                case Weapons.weapoRange:
                    {
                        player.AddItemToInventory(_weaponrange);
                    }
                    break;
            }
            player.AddItemToInventory(new HealthPotion("Potion"));
            return player;
        }
        public static Unit CreateGoblinEnemy() => _goblin;
    }
}
