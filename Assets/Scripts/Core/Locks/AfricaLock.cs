﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfricaLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown(){
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      GameObject ContinentsObj = GameObject.Find("Countries");
      Continents Cont = ContinentsObj.GetComponent<Continents>();
      if(moneyScript.CurrencyF >= 1000){
         moneyScript.CurrencyF -= 1000;
         Cont.ActivateAfrica();
         Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
