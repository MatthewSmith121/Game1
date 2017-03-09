using UnityEngine;
using System.Collections;

public class Shield : Weapon
{

    public Shield()
    {
        Name = "Default Shield";
        Description = "The first shield";
        WeaponType = WeaponTypes.Shield;
        Type = ItemTypes.Weapon;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Attack = Random.Range(1, 5);
    }


}
