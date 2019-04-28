using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour


{

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
}
