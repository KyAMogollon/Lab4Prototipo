using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    float time;
    bool pause;
    public static Action OnWin;
    public static Action OnLoose;
    [SerializeField] UIManager _ui;


    private void Start()
    {
        OnLoose = OnLooseAction;
        OnWin = OnWinAction;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }
    public void OnPause(InputAction.CallbackContext value)
    {
        if(value.started)
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        if(pause)
        {
            pause = false;
            Time.timeScale = 0; 
        }else if(pause == false)
        {
            pause = true;
            Time.timeScale = 1;  
        }
        
    }
    public void UpdateTime()
    {
        time += 1 * Time.deltaTime;
        _ui.UpdateTimeText((int)time);
    }
    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void OnLooseAction()
    {
        Time.timeScale = 0;
    }
    public void OnWinAction()
    {
        Time.timeScale = 0;
    }

}
