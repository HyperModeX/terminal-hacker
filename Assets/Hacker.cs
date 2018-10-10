using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level;
    enum Screen { MainMenu, Password, Win, EasterEgg };
    Screen currentScreen;

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to terminal hacker");
        Terminal.WriteLine("what would you like to hack?");

        Terminal.WriteLine("1. Your neighbors house");
        Terminal.WriteLine("2. Your local computer station");
        Terminal.WriteLine("3. The airforce base");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();

        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }

        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "Poop")
        {
            currentScreen = Screen.EasterEgg;
            Terminal.WriteLine("Ha Ha you're so funny!!!\nBut seriously, TYPE AN ANSWER!!!!");
        }
        else
        {
            Terminal.WriteLine("CHOOSE A LEVEL!!! Please.");
        }
    }

    void StartGame()
        {
            Terminal.WriteLine("You have chosen level " + level);
            Terminal.WriteLine("Please enter your password: ");
            currentScreen = Screen.Password;
    }
}
