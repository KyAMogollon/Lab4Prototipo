using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int health;
    public GameEventInt ModifyHealth;
    public GameEvent UpdateHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ModifyHealth.Raise(health);
            UpdateHealth.Raise();
            Destroy(gameObject);
        }
    }
}
