using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sold : MonoBehaviour
{
    public GameObject soldMagnet;
    public GameObject soldDP;
    public GameObject soldDJ;
    public GameObject soldShield;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int ismag = PlayerPrefs.GetInt("Magnet", 0);
        int isdp = PlayerPrefs.GetInt("DP", 0);
        int isdj = PlayerPrefs.GetInt("DJ", 0);
        int isshield = PlayerPrefs.GetInt("Shield", 0);


        if (ismag > 0)
        {
            soldMagnet.SetActive(true);
        }
        else
        {
            soldMagnet.SetActive(false);
        }

        if(isdp > 0)
        {
            soldDP.SetActive(true);
        }
        else
        {
            soldDP.SetActive(false);
        }
        if(isdj > 0)
        {
            soldDJ.SetActive(true);
        }
        else
        {
            soldDJ.SetActive(false);
        }
        if(isshield > 0)
        {
            soldShield.SetActive(true);
        }
        else
        {
            soldShield.SetActive(false);
        }


    }
}
