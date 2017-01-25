using UnityEngine;
using System.Collections;

public class Chest : Armor {

    public Chest()
    {
        Name = "Default Chest Armor";
        Description = "The first chest armor";
        Picture = "chest";
        ArmorType = ArmorTypes.Chest;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
