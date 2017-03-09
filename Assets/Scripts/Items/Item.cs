using UnityEngine;
using UnityEngine.UI;

public class Item {

    private const int NumberOfItemTypes = 2;

    public enum Stat
    {
        Level,
        Strength,
        Intelligence,
        Health
    };

    public enum ItemTypes
    {
        Armor,
        Weapon
    };

    protected Item()
    {
    }

    // Creates a random item with specified level
    public static Item CreateItem(int level)
    {
        int result = Random.Range(0, NumberOfItemTypes);
        switch(result)
        {
            case (int)ItemTypes.Armor:
                return Armor.RandomArmor(level);
            case (int)ItemTypes.Weapon:
                return Weapon.RandomWeapon(level);
            default:
                return new Item();
        }
    }

    public string Name { get; set; }
    public ItemTypes Type { get; set; }
    public string Description { get; set; }
    public string Flavour { get; set; }
    public string Picture { get; set; }

    public int Level { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Health { get; set; }

    public ItemAbility[] Abilities { get; set; }
}
