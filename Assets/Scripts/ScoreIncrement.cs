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

    private void Awake()
    {
        ScoreFloat = PlayerPrefs.GetFloat("Score");
        ClickValue = PlayerPrefs.GetFloat("ClickValue");
        GetComponent<Upgrade>().RebirthPrice = PlayerPrefs.GetFloat("RebirthPrice");
    }

    private void Update()
    {
        ScoreText.text = (ScoreFloat.ToString());
        PlayerPrefs.SetFloat("Score", ScoreFloat);
        PlayerPrefs.SetFloat("ClickValue", ClickValue);
        PlayerPrefs.SetFloat("RebirthPrice", GetComponent<Upgrade>().RebirthPrice);
    }

    public void ScoreIncrease (float x)
    {
        x = ClickValue;
        ScoreFloat += x;
    }


}
