using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Upgrade : MonoBehaviour
{

    public Text Rebirth_Cost;
    public float RebirthPrice = 10;


    private void Update()
    {
        Rebirth_Cost.text = RebirthPrice.ToString();
    }



    public void RebirthFunc(float x)
    {
        x = RebirthPrice;
        if (GetComponent<ScoreIncrement>().ScoreFloat - x >= 0 )
        {
            GetComponent<ScoreIncrement>().ScoreFloat -= x;
            x *= 2;
            GetComponent<ScoreIncrement>().ClickValue += 1;
        }
        RebirthPrice = x;
    }






}
