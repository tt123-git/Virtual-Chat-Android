using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinAdd : MonoBehaviour
{
    public Text text;

    public void addCoins()
    {
        int currentCoins = int.Parse(text.text); // ??????????
        int coinsToAdd = 500; // ?????????
        int newTotalCoins = currentCoins + coinsToAdd; // ?????????

        text.text = newTotalCoins.ToString(); // ????????????????
    }
}
