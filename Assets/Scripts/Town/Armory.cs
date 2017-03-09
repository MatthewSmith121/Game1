using UnityEngine;
using System;
using System.Collections.Generic;

public class Armory : MonoBehaviour
{
    private int activeItem = -1;
    public Vector2 scrollPosition = Vector2.zero;
    public Player player;
    public GameManager gameManager;

    private void ArmoryButton()
    {
        if (GUI.Button(new Rect(1000, 100, 100, 100), "Armory"))
        {
            if (gameManager.StateGame == GameState.State.Armory)
            {
                activeItem = -1;
                gameManager.StateGame = GameState.State.TownSquare;
            }
            else
            {
                gameManager.StateGame = GameState.State.Armory;
            }
        }
    }

    private void TavernScreen()
    {
        int numberOfItems = player.Items.Count;
        int barWidth = 40, barLength = 200;
        int scrollX = 1000, scrollY = 300;
        scrollPosition = GUI.BeginScrollView(new Rect(scrollX, scrollY, barLength + 20, 200), scrollPosition,
            new Rect(0, 0, barLength, numberOfItems * barWidth), false, true);
        for (int i = 0; i < numberOfItems; i++)
        {
            if (GUI.Button(new Rect(0, i * barWidth, barLength, barWidth), player.Items[i].Name))
            {
                activeItem = i;
            }
        }
        GUI.EndScrollView();

        if (activeItem != -1)
        {
            GUI.Label(new Rect(scrollX + barLength + 50, scrollY, 200, 50), "Name: " + player.Items[activeItem].Name);
            GUI.Label(new Rect(scrollX + barLength + 50, scrollY + 50, 200, 50), "Level: " + player.Items[activeItem].Level.ToString());
            GUI.Label(new Rect(scrollX + barLength + 50, scrollY + 100, 200, 50), "Strength: " + player.Items[activeItem].Strength.ToString());
        }
    }

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            player.Items.Add(Item.CreateItem(i));
        }
    }

    // Update the visual display
    void OnGUI()
    {
        ArmoryButton();

        // TownHall is now active
        if (gameManager.StateGame == GameState.State.Armory)
        {
            TavernScreen();
        }
    }
}
