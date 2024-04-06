using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PointSystem : MonoBehaviour
{
    public static Action<int> GainPoints;
    public static Action UpdatePoints;
    private int points;
    [SerializeField] UIManager _UI;
    // Start is called before the first frame update
    void Start()
    {
        GainPoints = UpdateCurrentPoint;
        UpdatePoints = UpdatePoint;
    }
    public void UpdateCurrentPoint(int value)
    {
        points += value;

    }
    public void UpdatePoint()
    {
        _UI.UpdateCoinText(points);
    }
    
}
