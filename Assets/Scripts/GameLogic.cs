using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameLogic: MonoBehaviour {
    [SerializeField] int top;
    [SerializeField] int bottom;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    void Start()
    {
        StartGame();
    }

	void StartGame () {
        NextGuess();
    }
	

    public void OnPressHigher()
    {
        if (bottom < 1000) {
            bottom = guess + 1;
        }
        NextGuess();
    }

    public void OnPressLower()
    {
        top = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = UnityEngine.Random.Range(bottom, top);
        guessText.text = guess.ToString();
        
    }


}
