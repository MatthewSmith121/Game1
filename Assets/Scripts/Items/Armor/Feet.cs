using UnityEngine;
using System.Collections;

public class Feet : Armor
{
    public Feet()
    {
        Name = "Default Boots";
        Description = "The first boots";
        Picture = "boots";
        ArmorType = ArmorTypes.Feet;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
