using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    public void StartGame()
    {
        // Startgame
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        // Quitgame
        Application.Quit();
    }
}

