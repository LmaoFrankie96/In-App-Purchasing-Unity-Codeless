using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    private int _playerCoins;
    [Header("In App Price Texts")]
    public Text consumablePrice;
    public Text nonConsumablePrice;

    [Header("In App Products")]
    public GameObject coin500;
    public GameObject removeAds;

    [Header("In App Product IDs")]
    private string _coin500ID = ".com.Adeetheknights._In_App_Testing.coin500";
    private string _removeAdsID = ".com.Adeetheknights._In_App_Testing.removeads";

    [Header("Currency Amounts")]
    public Text coinsAmount;
    private void Awake()
    {
        /*consumablePrice = coin500.GetComponent<IAPButton>().priceText;
        nonConsumablePrice = removeAds.GetComponent<IAPButton>().priceText;*/
        SetWallet();
    }

    public void OnPurchaseComplete(Product product)
    {

        if (product.definition.id == _coin500ID)
        {

            UpdateWallet();
            Debug.Log("500 coins purchased");

        }
        if (product.definition.id == _removeAdsID)
        {

            Debug.Log("Remove ads purchased");
        }
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureReason)
    {

        Debug.Log($"{product.definition.id} purchase failed because of {failureReason}");
    }
    private void UpdateWallet()
    {
        _playerCoins += 500;
        coinsAmount.text = _playerCoins.ToString();
        PlayerPrefs.SetInt("Coins", _playerCoins);
    }
    private void SetWallet()
    {

        _playerCoins = PlayerPrefs.GetInt("Coins", 0);
        coinsAmount.text = _playerCoins.ToString();
    }
}
