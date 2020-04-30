using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomicStability : MonoBehaviour
{
    public Slider esSlider;
    public Text economicStability;
    public float economicStabilityF;

    void Start()
    {
        esSlider.value = 100;
    }

    void Update()
    {
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();


      float diff1 = Math.Abs(moneyScript.Factories -  moneyScript.Fish);
      float diff2 = Math.Abs(moneyScript.Factories -  moneyScript.Mines);
      float diff3 = Math.Abs(moneyScript.Factories -  moneyScript.Wood);
      float diff4 = Math.Abs(moneyScript.Fish -  moneyScript.Mines);
      float diff5 = Math.Abs(moneyScript.Fish -  moneyScript.Wood);
      float diff6 = Math.Abs(moneyScript.Mines -  moneyScript.Wood);

      float avgDiff = diff1 + diff2 + diff3 + diff4 + diff5 + diff6 / 6;

      Debug.Log(avgDiff);


      economicStabilityF = 100 - (avgDiff * 2);
      esSlider.value = economicStabilityF;
      economicStability.text = "" + economicStabilityF;
      
    }
}