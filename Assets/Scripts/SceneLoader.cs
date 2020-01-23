using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class SceneLoader : MonoBehaviour
{
    public TextMeshProUGUI guessText;

    private void Start()
    {
        if (guessText != null)
        {
            SetGuessText(); 
        }    
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); 
    }

    public void LoadNextScene(int guess)
    {
        PlayerPrefs.SetInt("guess", guess); 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        PlayerPrefs.DeleteAll(); 
        SceneManager.LoadScene(0); 
    }

    public void SetGuessText()
    {
        guessText.text = PlayerPrefs.GetInt("guess", 0).ToString(); 
    }

    public void QuitApplication()
    {
        Application.Quit(); 
    }
}
