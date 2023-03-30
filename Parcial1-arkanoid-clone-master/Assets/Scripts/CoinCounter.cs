using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : SaveGame
{
    public TMP_Text coins;
    void Start()
    {
        coins = GetComponent<TextMeshProUGUI>();
        savePath = Application.persistentDataPath + "/SaveState.txt";
    }

    void Update()
    {
        LoadData();  
        
        coins.text = currentCoins.ToString();
    }
}