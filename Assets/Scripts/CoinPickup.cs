using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int pointsPerCoin = 100;    
    [SerializeField] AudioClip coinPickUpSFX;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision is CapsuleCollider2D)
        {
            FindObjectOfType<GameSession>().AddToScore(pointsPerCoin);
            AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
