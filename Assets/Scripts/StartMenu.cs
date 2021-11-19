using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene("StoryScreen");
    }

    public void Continue()
    {
        SceneManager.LoadScene("IntroScreen");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
