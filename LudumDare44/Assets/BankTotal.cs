using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BankTotal : MonoBehaviour
{

    TextMeshProUGUI bankText;
    float totalScore;
    float score;


    // Start is called before the first frame update
    void Start()
    {
        bankText = GetComponent<TextMeshProUGUI>();
        totalScore = PlayerPrefs.GetFloat("Total", 0);
    }

    // Update is called once per frame
    void Update()
    {
       
        totalScore = PlayerPrefs.GetFloat("Total", 0);

        bankText.text = "$" + totalScore.ToString("f2");
    }
}
