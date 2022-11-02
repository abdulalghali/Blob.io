using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;


    void Update()
    {
        PriceTxt.text = "Price: " + ShopManager.GetComponent<ShopManager>().ShopItems[2, ItemID].ToString();
        QuantityTxt.text = ShopManager.GetComponent<ShopManager>().ShopItems[3, ItemID].ToString();
    }
}
