using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int coins = 0;

    [SerializeField] private Text CoinCount;
    [SerializeField] private AudioSource CoinCollectSound;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            CoinCollectSound.Play();
            CoinCount.text = "Coins: " + coins + " / 7";
        }
    }
}
