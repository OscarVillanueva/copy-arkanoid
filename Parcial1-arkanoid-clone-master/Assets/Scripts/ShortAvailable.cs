using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShortAvailable : SaveGame
{
    [SerializeField] int tipo_shorts;
    public TMP_Text cShort;
    
    int available=1;

    int costoShortRojo = 5;
    int costoShortAzul = 10;
    int costoShortVerde = 25;

    void Start()
    {
        cShort = GetComponent<TextMeshProUGUI>();
        savePath = Application.persistentDataPath + "/SaveState.txt";
    }

    void Update()
    {
        LoadData();  

        if(tipo_shorts == 1&&currentCoins<costoShortRojo){available=0;}
        if(tipo_shorts == 2&&currentCoins<costoShortAzul){available=0;}   
        if(tipo_shorts == 3&&currentCoins<costoShortVerde){available=0;}                  


        if(available==1)
            cShort.text = "BUY";
        if(available==0)
            cShort.text = "XXX";            
    }
}
