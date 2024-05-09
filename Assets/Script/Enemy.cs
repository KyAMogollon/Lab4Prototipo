using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int value;
    public SpriteRenderer _sp;
    public PlayerController player;
    public GameEvent UpdateHealth;
    public GameEventInt ModifyHealth;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponentInChildren<SpriteRenderer>();
        player =FindAnyObjectByType<PlayerController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<SpriteRenderer>().color != _sp.color)
            {
                Debug.Log("Me hice daño");
                ModifyHealth.Raise(-value);
                UpdateHealth.Raise();
                player.canChangeColor = true;
            }
            else
            {
                player.canChangeColor = true;
            }
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.canChangeColor = false;
        }
    }
}
