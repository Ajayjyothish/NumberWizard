using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min ;
    int max ;
    int guess;
    // Use this for initialization
    void Start()
    {
        start_message();
    }

    void start_message()
    {
        min = 1;
        max = 100;
        guess = 50;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Think of a number between 1 and 100");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("The up arrow is pressed");
            min = guess;
            getGuess();
            Debug.Log("Is your number " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("The down arrow was pressed ");
            max = guess;
            getGuess();
            Debug.Log("Is your number " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You have won the game and you are dope");
            print("do you want to play again");
            
                Start();
           


            
        }

    }

    int getGuess()
    {
        guess = (min + max) / 2;
        return guess;
    }
}
