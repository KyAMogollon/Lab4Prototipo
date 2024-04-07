using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem.ModifyHealth?.Invoke(health);
            HealthSystem.UpdateHealth?.Invoke();
            Destroy(gameObject);
        }
    }
}
