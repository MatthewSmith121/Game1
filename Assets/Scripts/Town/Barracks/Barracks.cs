using UnityEngine;
using System.Collections.Generic;

public class Barracks : MonoBehaviour {

    public Player player;
    
    public void Barracks_Click()
    {
        BarracksPanel bp = BarracksPanel.Instance();
        bp.CharacterSheet(player.Staff[0]);
    }

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            Employee emp = new Employee("Employee Number " + (i + 1));
            player.Staff.Add(emp);
        }
    }
}
