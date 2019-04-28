using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour


{

    public float priceOfMagnet = 1000.00f;
    public float priceOfDoubleJump = 150.00f;
    public float priceOfShield = 150.00f;
    public float priceOfDoublePoint = 500.00f;


    public GameObject endMenu;
    public GameObject shop;


    public void openEndMenu()
    {
        shop.SetActive(false);

        endMenu.SetActive(true);
    }


    public void OpenShop()

    {
        shop.SetActive(true);

        endMenu.SetActive(false);

    }

    public void BuyMagnet()
    {
        float totalScore = PlayerPrefs.GetFloat("Total", 0);
        int hasMagnet = PlayerPrefs.GetInt("Magnet", 0);
        if (totalScore >= priceOfMagnet && hasMagnet < 1)
        {
            PlayerPrefs.SetInt("Magnet", 1);
            PlayerPrefs.SetFloat("Total", totalScore - priceOfMagnet);
        }
    }
    public void BuyDoubleJump()
    {
        float totalScore = PlayerPrefs.GetFloat("Total", 0);
        int hasDJ = PlayerPrefs.GetInt("DJ", 0);
        if (totalScore >= priceOfDoubleJump && hasDJ < 1)
        {
            PlayerPrefs.SetInt("DJ", 1);
            PlayerPrefs.SetFloat("Total", totalScore - priceOfDoubleJump);
        }
    }
    public void BuyDoublePoints()
    {
        float totalScore = PlayerPrefs.GetFloat("Total", 0);
        int hasDP = PlayerPrefs.GetInt("DP", 0);

        if (totalScore >= priceOfMagnet && hasDP < 1)
        {
            PlayerPrefs.SetInt("DP", 1);
            PlayerPrefs.SetFloat("Total", totalScore - priceOfDoublePoint);
        }
    }
    public void BuyShield()
    {
        float totalScore = PlayerPrefs.GetFloat("Total", 0);
        int hasShield = PlayerPrefs.GetInt("Shield", 0);

        if (totalScore >= priceOfMagnet && hasShield < 1)
        {
            PlayerPrefs.SetInt("Shield", 1);
            PlayerPrefs.SetFloat("Total", totalScore - priceOfShield);
        }
    }
}
