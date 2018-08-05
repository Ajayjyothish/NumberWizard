using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text text;
    int guess;
    [SerializeField] int numberoOfGuess;

    SceneLoader scene;

    // Use this for initialization
    void Start()
    {
        getGuess();
        max = max + 1;
        numberoOfGuess+=1;
    }

    // Update is called once per frame
    void Update()
    {

        if (numberoOfGuess == 0)
        {
            SceneManager.LoadScene("lose_game");
        }

        

    }

    public void onPressLower()
    {
        max = guess-1;
        getGuess();
        numberoOfGuess--;
        
        
    }

    public void onPressHigher()
    {
        min = guess+1;
        getGuess();
        numberoOfGuess--;
        
    }

    public int getGuess()
    {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        return guess;
    }
}
