using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfflineEarning : MonoBehaviour
{



    private DateTime currentTime = DateTime.UtcNow;
    private DateTime lastTimePlayed;
    private int LastTimePlayedInt;



    private void Start()
    {


        currentTime = DateTime.UtcNow;
        LastTimePlayedInt = PlayerPrefs.GetInt("LastTimePlayed");

        //currentTime - lastTimePlayed
        // x == time spent between the current time and the last time the user enter the game
        
        var x = (float)(currentTime - lastTimePlayed).TotalSeconds;
        GetComponent<ScoreIncrement>().ScoreFloat += x * (GetComponent<ScoreIncrement>().CpsValue);
    }

    private void Update()
    {
        lastTimePlayed = DateTime.UtcNow;
        PlayerPrefs.SetInt("LastTimePlayed", lastTimePlayed.Second);

        // saves information as  '    11/1/2023 10:04:23    '
    }






}
