using UnityEngine;
using System.Collections;

public class Hands : Armor
{
    public Hands()
    {
        Name = "Default Gloves";
        Description = "The first gloves";
        Picture = "hands";
        ArmorType = ArmorTypes.Hands;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
