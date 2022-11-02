using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int[,] ShopItems = new int[4,4];
    public float coins;
    public Text CoinsTxt;

    void Start()
    {
        CoinsTxt.text = "Coins:" + coins.ToString();

        //these are the ID's
        ShopItems[1, 1] = 1;
        ShopItems[1, 2] = 2;
        ShopItems[1, 3] = 3;

        //these are the prices
        ShopItems[2, 1] = 50;
        ShopItems[2, 2] = 40;
        ShopItems[2, 3] = 60;

        //Quantity
        ShopItems[3, 1] = 0;
        ShopItems[3, 2] = 0;
        ShopItems[3, 3] = 0;
    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= ShopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= ShopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            ShopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTxt.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = ShopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
        else
        {
            Debug.Log("Not enough coins for purchase");
        }
    }
}
