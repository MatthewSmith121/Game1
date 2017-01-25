using UnityEngine;
using System.Collections;

public class Legs : Armor
{
    public Legs()
    {
        Name = "Default Legs";
        Description = "The first leg armor";
        Picture = "legs";
        ArmorType = ArmorTypes.Legs;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
