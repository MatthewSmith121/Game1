using UnityEngine;
using System;
using System.Collections.Generic;

public class Tavern : MonoBehaviour {

    private DateTime LastUpdate;
    private int UpdateTime = 20;
    public List<Employee> Patrons = new List<Employee>();
    public Player player;

    public void Tavern_Click()
    {
        TavernPanel tp = TavernPanel.Instance();
        tp.CharacterSheet(Patrons[0], 0);
    }

    public void HireEmployee(int i)
    {
        player.Staff.Add(Patrons[i]);
    }

    /// <summary>
    /// Update the market to have new hires.
    /// </summary>
    private void UpdateTavern()
    {
        // Remove old hires
        Patrons.Clear();

        //Fill With new hires
        for (int i = 0; i < 10; i++)
        {
            Patrons.Add(new Employee("NewHire" + i));
        }
    }

    // Initialize the tavern
    void Awake()
    {
        UpdateTavern();
        LastUpdate = DateTime.Now;
    }

    // Update is called once per frame
    void Update() {
        TimeSpan duration = System.DateTime.Now - LastUpdate;
        if (duration.Minutes >= UpdateTime)
        {
            LastUpdate = System.DateTime.Now;
            UpdateTavern();
        }
    }
}
