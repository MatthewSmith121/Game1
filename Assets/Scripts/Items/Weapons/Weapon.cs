using UnityEngine;
using System;

public class Weapon : Item {

    //Name, Level, Strength, Intelligence, Health, Armor

    public enum WeaponTypes
    {
        Sword,
        Shield,
        Mace,
        Axe
    };

    public int Attack { get; set; }
    public WeaponTypes WeaponType { get; set; }

    public Weapon(string name, int level)
    {
        Name = name;
        Level = level;
        Attack = 100;
    }

    public Weapon(int level)
    {
        Strength = UnityEngine.Random.Range(1, level + 5);
        Intelligence = UnityEngine.Random.Range(1, level + 5);
        Health = UnityEngine.Random.Range(1, level + 5);
        Attack = UnityEngine.Random.Range(1, level + 5);
    }

    public Weapon()
    {
        Strength = UnityEngine.Random.Range(1, 100);
        Intelligence = UnityEngine.Random.Range(1, 100);
        Health = UnityEngine.Random.Range(1, 100);
        Attack = UnityEngine.Random.Range(1, 100);
    }

    public static Weapon RandomWeapon(int level)
    {
        int rnd = UnityEngine.Random.Range(0, 4);
        switch (rnd)
        {
            case (int)WeaponTypes.Sword:
                return new Sword();
            case (int)WeaponTypes.Shield:
                return new Shield();
            case (int)WeaponTypes.Mace:
                return new Mace();
            case (int)WeaponTypes.Axe:
                return new Axe();
            default:
                return new Sword();
        }
    }

}
