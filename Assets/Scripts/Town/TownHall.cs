using UnityEngine;
using System.Collections.Generic;

public class TownHall : MonoBehaviour {

    private enum States
    {
        QuestsDisplay,
        QuestSelected
    };

    public GameManager gameManager;
    public Player player;

    private Quest activeQuest;
    private Employee activeEmployee;
    private List<Quest> quests = new List<Quest>();
    private States currentState = States.QuestsDisplay;
    private int posX = 750, posY = 300;
    private int questNumber = 1;

    // Reset everything that should reset when you leave the TownHall
    private void Reset()
    {
        activeQuest = null;
        activeEmployee = null;
        currentState = States.QuestsDisplay;
    }

    // Run the active quest
    private void Embark()
    {
        int outcome = Random.Range(0, 100);
        if (outcome <= activeQuest.GetSuccess())
        {
            // Generate the phat loot
            for (int i = 0; i < activeQuest.Level; i++)
            {
                player.Items.Add(Item.CreateItem(activeQuest.Level));
            }
        }
        else
        {
            // Need to calculate each employees chance of survival and
            // figure out who dies and who lives
        }
        questNumber++;
        quests.Remove(activeQuest);
        quests.Add(new Quest("Quest " + questNumber, "New Description", questNumber));
        Reset();
    }

    private void SelectedQuestScreen()
    {
        int employeeListX = posX + 300;
        if (GUI.Button(new Rect(posX, posY - 50, 100, 50), "Return"))
        {
            Reset();
            return;
        }

        if (GUI.Button(new Rect(posX + 125, posY - 50, 100, 50), "Embark"))
        {
            Embark();
            return;
        }

        GUI.Label(new Rect(posX, posY, 200, 50), "Name: " + activeQuest.Name);
        GUI.Label(new Rect(posX, posY + 50, 200, 50), "Level: " + activeQuest.Level.ToString());
        GUI.Label(new Rect(posX, posY + 100, 200, 50), "Description: " + activeQuest.Description.ToString());
        GUI.Label(new Rect(posX, posY + 150, 200, 50), "Success: " + activeQuest.GetSuccess());
        GUI.Label(new Rect(posX, posY + 200, 200, 50), "Assigned Employees: " + activeQuest.Assigned.Count);

        int numberOfEmployees = player.Staff.Count;
        int barWidth = 40, barLength = 200;
        scrollPosition = GUI.BeginScrollView(new Rect(employeeListX, posY, barLength + 20, 200), scrollPosition,
            new Rect(0, 0, barLength, numberOfEmployees * barWidth), false, true);
        for (int i = 0; i < numberOfEmployees; i++)
        {
            if (GUI.Button(new Rect(0, i * barWidth, barLength, barWidth), "Employee " + (i + 1)))
            {
                activeEmployee = player.Staff[i];
            }
        }
        GUI.EndScrollView();

        if (activeEmployee != null)
        {
            EmployeeSelected(employeeListX, barLength, barWidth);   
        }
    }

    private void EmployeeSelected(int employeeListX, int barLength, int barWidth)
    {
        GUI.Label(new Rect(employeeListX + barLength + 50, posY, 200, 50), "Name: " + activeEmployee.Name);
        GUI.Label(new Rect(employeeListX + barLength + 50, posY + 50, 200, 50), "Level: " + activeEmployee.Level.ToString());
        GUI.Label(new Rect(employeeListX + barLength + 50, posY + 100, 200, 50), "Strength: " + activeEmployee.Strength.ToString());
        if (activeQuest.Assigned.Contains(activeEmployee))
        {
            // Employee is already on this quest
            if (GUI.Button(new Rect(employeeListX + barLength + 50, posY + 150, barLength, barWidth), "Unassign from Quest"))
            {
                activeQuest.UnassignEmployee(activeEmployee);
            }
        }
        else
        {
            // Employee is not already on this quest
            if (GUI.Button(new Rect(employeeListX + barLength + 50, posY + 150, barLength, barWidth), "Assign to Quest"))
            {
                activeQuest.AssignEmployee(activeEmployee);
            }
        }
    }

    private void ClickQuest(int i)
    {
        activeQuest = quests[i];
        currentState = States.QuestSelected;
    }

    /// <summary>
    /// Draw the TownHall window
    /// </summary>
    Vector2 scrollPosition = Vector2.zero;
    private void TownHallScreen()
    {
        int numberOfQuests = quests.Count;
        int barWidth = 40, barLength = 200;
        scrollPosition = GUI.BeginScrollView(new Rect(posX, posY, barLength + 20, 200), scrollPosition,
            new Rect(0, 0, barLength, numberOfQuests * barWidth), false, true);
        for (int i = 0; i < numberOfQuests; i++)
        {
            if (GUI.Button(new Rect(0, i * barWidth, barLength, barWidth), quests[i].Name))
            {
                ClickQuest(i);
            }
        }
        GUI.EndScrollView();

        if (activeQuest != null)
        {
            GUI.Label(new Rect(posX + barLength + 50, posY, 200, 50), "Name: " + activeQuest.Name);
            GUI.Label(new Rect(posX + barLength + 50, posY + 50, 200, 50), "Level: " + activeQuest.Level.ToString());
            GUI.Label(new Rect(posX + barLength + 50, posY + 100, 200, 50), "Description: " + activeQuest.Description.ToString());
        }
    }

    /// <summary>
    /// When TownHall is not active, a button should be shown that when clicked, activates TownHall
    /// If TownHall is already active, the button will instead deactivate TownHall
    /// </summary>
    private void TownHallButton()
    {
        if (GUI.Button(new Rect(750, 100, 100, 100), "Town Hall"))
        {
            if (gameManager.StateGame == GameState.State.TownHall)
            {
                Reset();
                gameManager.StateGame = GameState.State.TownSquare;
            }
            else
            {
                gameManager.StateGame = GameState.State.TownHall;
            } 
        }
    }

	// Use this for initialization
	void Awake () {
        quests.Add(new Quest());
        Reset();
	}
	
	// Update is called once per frame
	void OnGUI () {

        TownHallButton();

        // TownHall is now active
        if (gameManager.StateGame == GameState.State.TownHall)
        {
            if (currentState == States.QuestsDisplay)
            {
                TownHallScreen();
            }
            else if (currentState == States.QuestSelected)
            {
                SelectedQuestScreen();
            }
        }
	}
}
