﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentIndustrialized : MonoBehaviour
{
    public Text percent;
    public float percentF;

    void Start()
    {

    }

    void Update()
    {
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      percentF = moneyScript.Factories * 2 + moneyScript.Fish * 4/3 + moneyScript.Mines * 4/3 + moneyScript.Wood * 4/3;
      percent.text = "" + percentF;

    }
}
