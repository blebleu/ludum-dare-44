using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{


    public GameObject score;
    TextMeshProUGUI moneyText;
    public float moneyTotal;


    // Start is called before the first frame update
    void Start()
    {
        moneyTotal = score.GetComponent<s_money>().moneyTotal;
        moneyText = GetComponent<TextMeshProUGUI>();



    }

   
    // Update is called once per frame
    void Update()
    {
        moneyTotal = score.GetComponent<s_money>().moneyTotal;
        moneyText.text = "$" + moneyTotal.ToString("f2");
    }
}