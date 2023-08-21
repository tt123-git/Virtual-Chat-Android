using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinSave : MonoBehaviour
{
    public Text cointext;

    private void Start()
    {
        cointext.text = PlayerPrefs.GetString("coin", "0");
    }

    public void Save()
    {
        PlayerPrefs.SetString("coin", cointext.text);
        PlayerPrefs.Save();
    }

    public void LoadCoin()
    {
        int coinInitialize = 0;
        PlayerPrefs.SetInt("coin", coinInitialize);
        cointext.text = coinInitialize.ToString();
    }
}


