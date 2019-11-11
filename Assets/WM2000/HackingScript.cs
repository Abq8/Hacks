using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingScript : MonoBehaviour
{
    // Game state
    string healer;
    string password;
   
    enum Screen { MyMenu, Password, Win };
    Screen myScreen = Screen.MyMenu;
    void GameStrat()
    {
        myScreen = Screen.Password;
        Terminal.WriteLine("Initiating the hack on " + healer);
        switch (healer)
        {
            case 1:
                password = healer1Passwords[Random.Range(0, healer1Passwords.Hea]
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MyMenu("Ola!");
    }
    void MyMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Everything can be hack, and everyone!");
        Terminal.WriteLine("Press 1 for Mercy");
        Terminal.WriteLine("Press 2 for Lucio");
        Terminal.WriteLine("Press 3 for Ana");
        Terminal.WriteLine("Healers must be hacked");
    }
    void SetHealer(string selectedHealer)
    {
        if (selectedHealer == "1")
        {
            healer = "Mercy";
            GameStrat();
        }
        else if (selectedHealer == "2")
        {
            healer = "Lucio";
            GameStrat();
        }
        else if (selectedHealer == "3")
        {
            healer = "Ana";
            GameStrat();
        }
    }
    
      void OnUserInput(string input)
    {
        if (input == "menu")
        {
            MyMenu("I been here all along!");
        }
        else
        {
            SetHealer(input);
        }
    }


    string[] healer1Passwords = { "wings", "angel", "doctor", "angela" };
    string[] healer2Passwords = { "beat", "speed", "boost", "wall" };
    string[] healer3Passwords = { "sleep", "nano", "mother", "snipe" };

    void CheckPassword(string input)
    {
        if (input == password)
    }












    // Update is called once per frame
    void Update()
    {       
    }
}
