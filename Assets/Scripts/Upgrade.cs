using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Upgrade : MonoBehaviour
{

    public Text CV_Price_Text;
    public float CV_Price = 10;


    private void Update()
    {
        //CV_Price_Text.text = CV_Price.ToString();
    }



    public void CVIncrement(float x)
    {
        x = CV_Price;
        if (GetComponent<ScoreIncrement>().ScoreFloat - x >= 0 )
        {
            GetComponent<ScoreIncrement>().ScoreFloat -= x;
            x *= 2;
            GetComponent<ScoreIncrement>().ClickValue += 1;
        }
        CV_Price = x;
    }






}
