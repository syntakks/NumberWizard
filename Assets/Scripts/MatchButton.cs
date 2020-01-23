using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MatchButton : MonoBehaviour
{
    public GameObject sceneLoader;
    public GameObject gamePlay; 
    private Button matchButton;

    // Start is called before the first frame update
    void Start()
    {
        matchButton = GetComponent<Button>();
        matchButton.onClick.AddListener( delegate { OnMatchButton(); }); 
    }

    private void OnMatchButton()
    {
        int guess = gamePlay.GetComponent<NumberWizard>().guess;
        PlayerPrefs.SetInt("guess", guess);
        sceneLoader.GetComponent<SceneLoader>().LoadNextScene(); 
    }

}
