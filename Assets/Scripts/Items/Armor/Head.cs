using UnityEngine;
using System.Collections;

public class Head : Armor
{
    public Head()
    {
        Name = "Default Helmet";
        Description = "The first helmet";
        Picture = "Helmet";
        ArmorType = ArmorTypes.Head;
        Type = ItemTypes.Armor;
        Level = 1;
        Strength = Random.Range(1, 5);
        Intelligence = Random.Range(1, 5);
        Health = Random.Range(1, 5);
        Defence = Random.Range(1, 5);
    }
}
