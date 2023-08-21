using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinAdd300 : MonoBehaviour
{
    public Text text;

    public void addCoins()
    {
        int currentCoins = int.Parse(text.text); // ??????????
        int coinsToAdd = 100; // ?????????
        int newTotalCoins = currentCoins + coinsToAdd; // ?????????

        text.text = newTotalCoins.ToString(); // ????????????????
    }
}
