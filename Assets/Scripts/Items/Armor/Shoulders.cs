using UnityEngine;
using System.Collections;

public class Shoulders : Armor
{
    public Shoulders()
    {
        Name = "Default Shoulders";
        Description = "The first shoulders";
        Picture = "shoulders";
        ArmorType = ArmorTypes.Shoulders;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
