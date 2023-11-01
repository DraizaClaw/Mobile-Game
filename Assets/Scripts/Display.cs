using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{


    //cv price
    //cps price
    //score


    public Text cv_price;
    public Text cps_price;
    public Text score;








    private Cps CPS;
    private Upgrade Upgrade;
    private ScoreIncrement scoreIncrement;



    private void Awake()
    {
        CPS = GetComponent<Cps>();
        Upgrade = GetComponent<Upgrade>();
        scoreIncrement = GetComponent<ScoreIncrement>();
    }

    private void Update()
    {



        score.text = (shorten(scoreIncrement.ScoreFloat));
        cps_price.text = (shorten(CPS.CPS_Price));
        cv_price.text = (shorten(Upgrade.CV_Price));



    }


    public string shorten(float num)
    {
        string[] placeholders = new string[]{ "", " K", " M", " B", " T"  };



        for (var i = 0; i < placeholders.Length; i++)
        {
            if (num >= 1000)
            {
                num /= 1000;
            }
            else
            {
                var x = num;
                x *= 10;    x = (int)x;     x /= 10;


                return x + placeholders[i];
            }
        }
        return ("Error");
    }




}
