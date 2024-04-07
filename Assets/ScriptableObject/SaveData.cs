using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataSave", order = 0)]
public class SaveData : ScriptableObject
{
    public int coins;
    public int time;

    public void SaveCoin(int coin)
    {
        coins = coin;
    }
    public void SaveTime(int tiempo)
    {
        time = tiempo;
    }
}
