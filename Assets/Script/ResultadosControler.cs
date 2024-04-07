using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultadosControler : MonoBehaviour
{
    public Text coin;
    public Text time;
    public SaveData saveData;

    private void Start()
    {
        UpdateCoin();
        UpdateTime();
    }
    public void UpdateCoin()
    {
        coin.text = "Coins: " + saveData.coins;
    }
    public void UpdateTime()
    {
        time.text = "Time: " + saveData.time;
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene("Inicio");
    }
}
