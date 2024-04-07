using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text coins;
    public Text life;
    public Text time;
    public Canvas winCanvas;
    public Canvas looseCanvas;
    [SerializeField] PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        coins.text = "Coin: " + 0;
        life.text = "Life: " + player.life;
    }

    public void UpdateTimeText(int currentTime)
    {
        time.text = "Time: " + currentTime;
    }
    public void UpdateCoinText(int coin)
    {    
        coins.text = "Coin: " + coin;
        if(coin >= 40)
        {
            ActivateWin();
        }
    }
    public void UpdateLifeText(int vida)
    {
        int currentLife = player.life + vida; 
        life.text = "Life: " + currentLife;
        if(currentLife <= 0) 
        {
            ActivateLoose();
        }
    }
    public void ActivateWin()
    {
        GameManager.OnWin?.Invoke();
        winCanvas.gameObject.SetActive(true);
    }
    public void ActivateLoose()
    {
        GameManager.OnLoose?.Invoke();
        looseCanvas.gameObject.SetActive(true);
    }

}
