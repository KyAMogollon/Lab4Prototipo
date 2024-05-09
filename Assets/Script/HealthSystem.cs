using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    private int health;
    [SerializeField] UIManager _UI;

    public void UpdateCurrentHealth(int vida)
    {
        health += vida;
    }
    public void HealthUpdate()
    {
        _UI.UpdateLifeText(health);
    }
}
