using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinAdd2000 : MonoBehaviour
{
    public Text text;

    public void addCoins()
    {
        int currentCoins = int.Parse(text.text); // 現在のコイン数を取得
        int coinsToAdd = 2000; // 加算するコインの量
        int newTotalCoins = currentCoins + coinsToAdd; // 加算後の総コイン数

        text.text = newTotalCoins.ToString(); // 加算後のコイン数をテキストに反映
    }
}