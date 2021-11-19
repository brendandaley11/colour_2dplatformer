using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void Level1To2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level2To3()
    {
        SceneManager.LoadScene("Level3");
    }
}
