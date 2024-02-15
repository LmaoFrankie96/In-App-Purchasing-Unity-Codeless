using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    [Header("In App Price Texts")]
    public Text consumablePrice;
    public Text nonConsumablePrice;

    [Header("In App Products")]
    public GameObject coin500;
    public GameObject removeAds;
    private void Awake()
    {
        consumablePrice = coin500.GetComponent<IAPButton>().priceText;
        nonConsumablePrice = removeAds.GetComponent<IAPButton>().priceText;
    }
}
