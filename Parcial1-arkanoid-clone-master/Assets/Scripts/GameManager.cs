using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : ChangeFade
{
    public static GameManager sharedInstance;

    private int leftBlocks;
    private string nextLevelName;

    public int Points { set; get; }

    void Start()
    {
        savePath = Application.persistentDataPath + "/SaveState.txt";
    }

    private void Awake()
    {
        if (!sharedInstance)
        {
            sharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void StartLevel(int currentBlocks, string nextLevel)
    {
        nextLevelName = nextLevel;
        leftBlocks = currentBlocks;
    }

    private void GoToNextLevel()
    {
        playAudio();
        SaveData();        
        GoToStore();
    }

    public void AddPoints(int points)
    {
        LoadData();
        currentCoins += points;
        SaveData();
        leftBlocks -= 1;

        if (leftBlocks <= 0)
        {
            playAudio();            
            GoToStore();
        }
    }
}
