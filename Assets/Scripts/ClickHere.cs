using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickHere : MonoBehaviour
{

    [SerializeField] private Image clickerRegion;

    public void Emphasis()
    {
        clickerRegion.rectTransform.localScale = new Vector3(3, 3, 3);

        print("waittforme");
        Invoke("ReturntoNormal", 1);
        print("waittforme2");


    }


    private void ReturntoNormal()
    {
        clickerRegion.rectTransform.localScale = new Vector3(1, 1, 1);
    }
}
