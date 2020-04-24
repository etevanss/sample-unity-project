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
        esSlider.value = 1/2;
    }

    void Update()
    {
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      //TODO: ECO STABILITY
      economicStabilityF = moneyScript.Factories * 2 + moneyScript.Fish * 4/3 + moneyScript.Mines * 4/3 + moneyScript.Wood * 4/3;
      esSlider.value = economicStabilityF;
      economicStability.text = "" + economicStabilityF;
      
    }
}