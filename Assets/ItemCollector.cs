using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private int coins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            collectionSoundEffect.Play();
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
