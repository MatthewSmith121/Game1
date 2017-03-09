using UnityEngine;
using System.Collections;

public class Sword : Weapon {

    public Sword()
    {
        Name = "Default Sword";
        Description = "The first sword";
        Picture = "sword";
        WeaponType = WeaponTypes.Sword;
        Type = ItemTypes.Weapon;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Attack = Random.Range(1, 5);
    }
	

}
