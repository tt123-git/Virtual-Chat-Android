using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using Unity.VisualScripting;

public class MyGold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyGold(UnityEngine.Purchasing.Product product)
    {
        CustomEvent.Trigger(gameObject, "addCOINS", product.definition.payout.quantity);
        
    }
}
