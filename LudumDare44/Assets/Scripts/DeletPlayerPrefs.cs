using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletPlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void delete()
    {
        PlayerPrefs.DeleteAll();
        GameObject money = GameObject.FindWithTag("Money");
        money.GetComponent<s_money>().moneyTotal = 0.00f;



    }
}

