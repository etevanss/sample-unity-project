using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicTotals : MonoBehaviour
{

    public Text MineTotal;
    public Text FacTotal;
    public Text FarmTotal;
    public Text WoodTotal;

    void Update()
    {
        GameObject MoneyListener = GameObject.Find("Money Listener");
        Money moneyScript = MoneyListener.GetComponent<Money>();

        MineTotal.text = "" + moneyScript.Mines;
        FacTotal.text = "" + moneyScript.Factories;
        FarmTotal.text = "" + moneyScript.Fish;
        WoodTotal.text = "" + moneyScript.Wood;
        
    }
}
