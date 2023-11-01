using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScoreIncrement : MonoBehaviour
{

    public float ScoreFloat;
    public float ClickValue = 1;
    public float CpsValue = 0;





    private void Start()
    {


        InvokeRepeating("CPerSec", 0, 1);


        ScoreFloat = PlayerPrefs.GetFloat("Score");
        ClickValue = PlayerPrefs.GetFloat("ClickValue");
        CpsValue = PlayerPrefs.GetFloat("CpsValue");


        GetComponent<Cps>().CPS_Price = PlayerPrefs.GetFloat("Cps_Price");



        GetComponent<Upgrade>().CV_Price = PlayerPrefs.GetFloat("CV_Price");


        
    }

    private void Update()
    {

        PlayerPrefs.SetFloat("Score", ScoreFloat);
        
        PlayerPrefs.SetFloat("ClickValue", ClickValue);
        PlayerPrefs.SetFloat("CpsValue", CpsValue);


        PlayerPrefs.SetFloat("CV_Price", GetComponent<Upgrade>().CV_Price);
        PlayerPrefs.SetFloat("Cps_Price" , GetComponent<Cps>().CPS_Price);

        
        //  ScoreFloat += Mathf.Round(CpsValue * Time.fixedDeltaTime);

        
    }



    private void CPerSec()
    {
        ScoreFloat += Mathf.Round(CpsValue);
    }






    public void ScoreIncrease (float x)
    {
        x = ClickValue;
        ScoreFloat += x;
    }

    public void Restart()
    {
        PlayerPrefs.DeleteAll();
        ClickValue = 1;
        CpsValue = 0;
        ScoreFloat = 0;
        GetComponent<Upgrade>().CV_Price = 10;
        GetComponent<Cps>().CPS_Price = 10;

    }

}
