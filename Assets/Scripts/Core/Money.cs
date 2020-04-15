using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int Fish = 0;
    public int Wood = 0;
    public int Factories = 0;
    public int Mines = 0;

    public Text Currency;
    public float CurrencyF;
    public float CurrencyRound;

    public Text fishPrice;
    public float fishF;
    public float fishRound;

    public Text woodPrice;
    public float woodF;
    public float woodRound;

    public Text factoryPrice;
    public float factoryF;
    public float factoryRound;

    public Text minePrice;
    public float mineF;
    public float mineRound;



    void Start()
    {

      fishPrice.text = "" + 5;
      woodPrice.text = "" + 5;
      factoryPrice.text = "" + 20;
      minePrice.text = "" + 5;

      CurrencyF = 5;
      CurrencyRound = Mathf.RoundToInt(CurrencyF);
      Currency.text = "" + CurrencyRound;
    }

    void FixedUpdate()
    {
        CurrencyF += Factories / 50;
        CurrencyF += Time.deltaTime * ( Factories + Wood * 4 / 3 + Fish * 4 / 3 + Mines * 4 / 3);
        CurrencyRound = Mathf.RoundToInt(CurrencyF);
        Currency.text = "" + CurrencyRound;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
