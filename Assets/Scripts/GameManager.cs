using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public Employee emp;
    public Quest q = new Quest();

    public GameState.State StateGame { get; set; }

    // Use this for initialization
    void Awake () {
        StateGame = GameState.State.TownSquare;
        /*
        Text aText = GameObject.Find("ArmorText").GetComponent<Text>();
        Text sText = GameObject.Find("StrengthText").GetComponent<Text>();
        Text iText = GameObject.Find("IntText").GetComponent<Text>();
        Text hText = GameObject.Find("HealthText").GetComponent<Text>();
        Text qName = GameObject.Find("questName").GetComponent<Text>();
        Text qDesc = GameObject.Find("questDesc").GetComponent<Text>();
        Text qLevel = GameObject.Find("questLevel").GetComponent<Text>();
        Text qSuc = GameObject.Find("questSuc").GetComponent<Text>();
        emp = new Employee("Matthew");
        adventurers.Add(emp);
        aText.text = "Attack: " + emp.Attack.ToString();
        sText.text = "Strength: " + emp.Strength.ToString();
        iText.text = "Intelligence: " + emp.Intelligence.ToString();
        hText.text = "Defence: " + emp.Defence.ToString();
        qName.text = q.Name;
        qDesc.text = q.Description;
        qLevel.text = q.Level.ToString();
        qSuc.text = q.GetSuccess(adventurers).ToString();   */     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
