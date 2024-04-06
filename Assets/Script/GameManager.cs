using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    float time;
    bool pause;
    public static Action OnWin;
    public static Action OnLoose;
    [SerializeField] UIManager _ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }
    public void UpdateTime()
    {
        time += 1 * Time.deltaTime;
        _ui.UpdateTimeText((int)time);
    }

}
