using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level;

    enum Screen { MainMenu, Password, Win, EasterEgg };
    Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
	void Start () {
        ShowMainMenu("Hello Zac");
    }

    void ShowMainMenu (string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Welcome to terminal hacker");
        Terminal.WriteLine("what would you like to hack?");

        Terminal.WriteLine("1. Your neighbors house");
        Terminal.WriteLine("2. Your local computer station");
        Terminal.WriteLine("3. The airforce base");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "Poop")
        {
            Terminal.WriteLine("Ha Ha you're so funny!!!\nBut seriously, TYPE AN ANSWER!!!!");
            currentScreen = Screen.EasterEgg;
        }
        else if (input == "1")
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
        else if (input == "menu")
        {
            ShowMainMenu("Hello Zac");
        }
        else {
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
