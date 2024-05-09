using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int value;
    public GameEventInt GainPoints;
    public GameEvent UpdateCoin;
    public void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            GainPoints.Raise(value);
            UpdateCoin.Raise();
            Destroy(gameObject);
        }
    }
}
