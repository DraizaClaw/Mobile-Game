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



        GetComponent<Upgrade>().RebirthPrice = PlayerPrefs.GetFloat("RebirthPrice");
        if (PlayerPrefs.GetFloat("RebirthPrice") >= 0)
        {
            PlayerPrefs.SetFloat("RebirthPrice", 10);
        }
    }

    private void Update()
    {

        ScoreText.text =  Mathf.Round(ScoreFloat).ToString();
        PlayerPrefs.SetFloat("Score", ScoreFloat);
        PlayerPrefs.SetFloat("ClickValue", ClickValue);
        PlayerPrefs.SetFloat("RebirthPrice", GetComponent<Upgrade>().RebirthPrice);
        PlayerPrefs.SetFloat("CpsValue" , CpsValue);

        ScoreFloat += CpsValue * Time.fixedDeltaTime; 
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
        GetComponent<Upgrade>().RebirthPrice = 10;
        GetComponent<Cps>().CPS_Price = 10;

    }


}
