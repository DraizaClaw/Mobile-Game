using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScoreIncrement : MonoBehaviour
{

    public Text ScoreText;
    public float ScoreFloat;
    public float ClickValue = 1;
    public float CpsValue = 0;




    private void Awake()
    {
        ScoreFloat = PlayerPrefs.GetFloat("Score");
        ClickValue = PlayerPrefs.GetFloat("ClickValue");
        ClickValue = PlayerPrefs.GetFloat("ClickValue");
        CpsValue = PlayerPrefs.GetFloat("CpsValue");


        GetComponent<Cps>().CPS_Price = PlayerPrefs.GetFloat("CpsValue");



        GetComponent<Upgrade>().CV_Price = PlayerPrefs.GetFloat("CV_Price");
    }

    private void Update()
    {

        //ScoreText.text =  Mathf.Round(ScoreFloat).ToString();
        PlayerPrefs.SetFloat("Score", ScoreFloat);
        PlayerPrefs.SetFloat("ClickValue", ClickValue);
        PlayerPrefs.SetFloat("CV_Price", GetComponent<Upgrade>().CV_Price);
        PlayerPrefs.SetFloat("CpsValue" , CpsValue);

        
        //  ScoreFloat += Mathf.Round(CpsValue * Time.fixedDeltaTime);

        //StartCoroutine(PerSec());
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


    IEnumerator PerSec()
    {

        yield return new WaitForSeconds(1);
        ScoreFloat += CpsValue;
    }


}
