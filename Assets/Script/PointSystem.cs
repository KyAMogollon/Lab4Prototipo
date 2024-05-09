using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PointSystem : MonoBehaviour
{
    public int points;
    [SerializeField] UIManager _UI;

    public void UpdateCurrentPoint(int value)
    {
        Debug.Log("Sumando: " + value);
        points += value;
    }
    public void UpdatePoint()
    {
        _UI.UpdateCoinText(points);
    }
    
}
