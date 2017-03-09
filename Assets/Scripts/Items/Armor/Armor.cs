using UnityEngine;

public class Armor : Item
{

    //Name, Level, Strength, Intelligence, Health, Armor

    public enum ArmorTypes
    {
        Head,
        Shoulders,
        Chest,
        Hands,
        Legs,
        Feet
    };


    public int Defence { get; set; }
    public ArmorTypes ArmorType { get; set; }

    public Armor(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Armor(int level)
    {
        Name = "Default Armor";
        Strength = Random.Range(1, level + 5);
        Intelligence = Random.Range(1, level + 5);
        Health = Random.Range(1, level + 5);
        Defence = Random.Range(1, level + 5);
    }

    public Armor()
    {
        Strength = Random.Range(1, 100);
        Intelligence = Random.Range(1, 100);
        Health = Random.Range(1, 100);
        Defence = Random.Range(1, 100);
    }

    public static Armor RandomArmor(int level)
    {
        int rnd = UnityEngine.Random.Range(0, 6);
        switch (rnd)
        {
            case (int)ArmorTypes.Head:
                return new Head();
            case (int)ArmorTypes.Shoulders:
                return new Shoulders();
            case (int)ArmorTypes.Chest:
                return new Chest();
            case (int)ArmorTypes.Hands:
                return new Hands();
            case (int)ArmorTypes.Legs:
                return new Legs();
            case (int)ArmorTypes.Feet:
                return new Feet();
            default:
                return new Head();
        }
    }
}
