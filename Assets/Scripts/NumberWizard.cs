using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI guessText; 
    public int max = 1000;
    public int min = 1;
    public int guess;

    private void Start()
    {
        max = max + 1;
        guess = Random.Range(min, max); 
        SetGuessText(); 
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }

    public void OnGuessHigher()
    {
        min = guess;
        NextGuess();
        SetGuessText();
    }

    public void OnGuessLower()
    {
        max = guess;
        NextGuess();
        SetGuessText();
    }

    private void SetGuessText()
    {
        guessText.text = guess.ToString(); 
    }
}
