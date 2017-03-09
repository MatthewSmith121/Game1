using UnityEngine;
using System.Collections;

public class Mace: Weapon
{

    public Mace()
    {
        Name = "Default Mace";
        Description = "The first mace";
        WeaponType = WeaponTypes.Mace;
        Type = ItemTypes.Weapon;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Attack = Random.Range(1, 5);
    }


}
