using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentIndustrialized : MonoBehaviour
{
    public GameObject canvas;
    public Text percent;
    public float percentF;

    void Start()
    {

    }

    void Update()
    {
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      percent.text = "" + (moneyScript.Factories * 5);

    }
}
