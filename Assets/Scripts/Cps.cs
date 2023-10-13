using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cps : MonoBehaviour
{

    public Text CPS_Cost;
    public float CPS_Price = 10;

    private void Update()
    {
        CPS_Cost.text = Mathf.Round(CPS_Price).ToString();
    }

    public void CpsUpgrade(float x)
    {
        x = CPS_Price;
        if (GetComponent<ScoreIncrement>().ScoreFloat - x >= 0)
        {
            GetComponent<ScoreIncrement>().ScoreFloat -= x;
            x *= 2.5f;
            GetComponent<ScoreIncrement>().CpsValue += 0.75f; //score increases by cps every sec
        }
        CPS_Price = x;
    }




}
