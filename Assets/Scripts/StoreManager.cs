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
    //public Product coin500;
    //public Product newBike;
    public Button coin500Btn;
    public Button newBikeBtn;
    public Text newBikeText;

    [Header("In App Product IDs")]
    private string _coin500ID = ".com.adeetheknights._In_App_Testing.coin500Btn";
    private string _newBikeID = ".com.adeetheknights._In_App_Testing.buynewbike";

    [Header("Currency Amounts")]
    public Text coinsAmount;

    [Header("Inventory Items")]
    public Image bikeIcon;
    private void Awake()
    {
        SetWallet();
        SetInventory();
        consumablePrice = coin500Btn.GetComponentInParent<IAPButton>().priceText;
        //nonConsumablePrice = newBikeBtn.GetComponent<IAPButton>().priceText;
    }

    public void OnPurchaseComplete(Product product)
    {

        if (product.definition.id == _coin500ID)
        {

            UpdateWallet();
            Debug.Log("500 coins purchased");

        }
        if (product.definition.id == _newBikeID)
        {
            PlayerPrefs.SetInt("Bike1", 1);
            bikeIcon.gameObject.SetActive(true);
            DisablePurchaseButton(newBikeBtn, newBikeText);
            Debug.Log("New Bike purchased");
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
    private void SetInventory() {

        if (PlayerPrefs.GetInt("Bike1", 0) == 1) {

            bikeIcon.gameObject.SetActive(true);
            DisablePurchaseButton(newBikeBtn, newBikeText);
        }
    }
    private void DisablePurchaseButton(Button button, Text text) {
        button.interactable = false;
        text.text = "Purchased";

    }
  
}
