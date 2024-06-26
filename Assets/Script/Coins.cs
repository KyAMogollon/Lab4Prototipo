using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PointSystem.GainPoints?.Invoke(value);
            PointSystem.UpdatePoints?.Invoke();
            Destroy(gameObject);
        }
    }
}
