using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class s_money : MonoBehaviour
{


    
    public TextMeshPro moneyText;
    public float moneyTotal = .00f;


    // Start is called before the first frame update
    void Start()
    {
        moneyTotal = .0f;
        moneyText = GetComponent<TextMeshPro> ();
        

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + moneyTotal.ToString("f2");
    }
}
