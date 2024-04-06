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

    // Start is called before the first frame update
    void Start()
    {
        coins.text = "Coin: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateTimeText(int currentTime)
    {
        time.text = "Time: " + currentTime;
    }
    public void UpdateCoinText(int coin)
    {
        coins.text = "Coin: " + coin;
    }

}
