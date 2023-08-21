using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using System;

[Serializable]
public class ConsumableItem
{
    public string Name;
    public string Id;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem500
{
    public string Name;
    public string Id500;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem1000
{
    public string Name;
    public string Id1000;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem2000
{
    public string Name;
    public string Id2000;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem3000
{
    public string Name;
    public string Id3000;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem8000
{
    public string Name;
    public string Id8000;
    public string desc;
    public float price;
}

[Serializable]
public class ConsumableItem10000
{
    public string Name;
    public string Id10000;
    public string desc;
    public float price;
}


public class coinAdd500 : MonoBehaviour, IStoreListener
{
    IStoreController m_StoreController;

    public Text text;
    public ConsumableItem cItem;
    public ConsumableItem cItem500;
    public ConsumableItem cItem1000;
    public ConsumableItem cItem2000;
    public ConsumableItem cItem3000;
    public ConsumableItem cItem8000;
    public ConsumableItem cItem10000;

    private void Start()
    {
        SetupBuilder();
        text.text = PlayerPrefs.GetString("coin", "0");
        Debug.Log(1);
    }


    void SetupBuilder()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(cItem.Id, ProductType.Consumable);
        builder.AddProduct(cItem500.Id, ProductType.Consumable);
        builder.AddProduct(cItem1000.Id, ProductType.Consumable);
        builder.AddProduct(cItem2000.Id, ProductType.Consumable);
        builder.AddProduct(cItem3000.Id, ProductType.Consumable);
        builder.AddProduct(cItem8000.Id, ProductType.Consumable);
        builder.AddProduct(cItem10000.Id, ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);

        Debug.Log(2);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        m_StoreController = controller;
        Debug.Log("Success");
        Debug.Log(3);
    }

    public void addCoins()
    {
        m_StoreController.InitiatePurchase(cItem.Id);
        m_StoreController.InitiatePurchase(cItem500.Id);
        m_StoreController.InitiatePurchase(cItem1000.Id);
        m_StoreController.InitiatePurchase(cItem2000.Id);
        m_StoreController.InitiatePurchase(cItem3000.Id);
        m_StoreController.InitiatePurchase(cItem8000.Id);
        m_StoreController.InitiatePurchase(cItem10000.Id);

        Debug.Log(4);
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        var product = purchaseEvent.purchasedProduct;
        Debug.Log("Purchase Complete" + product.definition.id);

        if (product.definition.id == cItem.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 300; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem500.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 500; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem1000.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 1000; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem2000.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 2000; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem3000.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 3000; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem8000.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 8000; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }
        if (product.definition.id == cItem10000.Id)
        {
            int currentCoins = int.Parse(text.text); // ??????????
            int coinsToAdd = 10000; // ?????????
            int newTotalCoins = currentCoins + coinsToAdd; // ?????????

            text.text = newTotalCoins.ToString(); // ????????????????

            PlayerPrefs.SetString("coin", text.text);
            PlayerPrefs.Save();
        }

        Debug.Log(5);

        return PurchaseProcessingResult.Complete;
    }

    public void Save()
    {
        PlayerPrefs.SetString("coin", text.text);
        PlayerPrefs.Save();
        Debug.Log(6);
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("initialize failed" + error);
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        Debug.Log("initialize failed" + error + message);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log("purchase faild");
    }

}
