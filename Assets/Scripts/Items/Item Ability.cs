using UnityEngine;
using System.Collections;

public class ItemAbility {

    public string Description { get; set; }
    public int Modifier { get; set; }
    public Item.Stat StatChanged { get; set; }

    public ItemAbility(string description, int modifier, Item.Stat statChanged)
    {
        Description = description;
        Modifier = modifier;
        StatChanged = statChanged;
    }

}
