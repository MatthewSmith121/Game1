using UnityEngine;
using System.Collections;

public class Axe : Weapon
{

    public Axe()
    {
        Name = "Default Axe";
        Description = "The first exe";
        WeaponType = WeaponTypes.Axe;
        Type = ItemTypes.Weapon;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Attack = Random.Range(1, 5);
    }


}
