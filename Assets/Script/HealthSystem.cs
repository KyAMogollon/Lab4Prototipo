using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    public static Action<int> ModifyHealth;
    public static Action UpdateHealth;
    private int health;
    [SerializeField] UIManager _UI;
    // Start is called before the first frame update
    void Start()
    {
        ModifyHealth = UpdateCurrentHealth;
        UpdateHealth = HealthUpdate;
    }
    public void UpdateCurrentHealth(int vida)
    {
        health += vida;
    }
    public void HealthUpdate()
    {
        _UI.UpdateLifeText(health);
    }
}
