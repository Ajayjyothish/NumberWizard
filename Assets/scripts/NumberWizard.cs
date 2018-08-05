using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text text;
    int guess;

    
    // Use this for initialization
    void Start()
    {
        guess = (min + max) / 2;
        text.text = guess.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {

       

        

    }

    public void onPressLower()
    {
        max = guess;
        getGuess();
        text.text = guess.ToString();
        
    }

    public void onPressHigher()
    {
        min = guess;
        getGuess();
        text.text = guess.ToString();
    }

    public int getGuess()
    {
        guess = (min + max) / 2;
        return guess;
    }
}
