using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel3 : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;
    // Start is called before the first frame update
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted && ItemCollector.coins == 7)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel3", 3f);
            ItemCollector.coins = 0;
        }
        else
        {
            return;
        }
    }

    private void CompleteLevel3()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
