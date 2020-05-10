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
    public int fishP = 5;

    public Text woodPrice;
    public float woodF;
    public float woodRound;
    public int woodP = 5;

    public Text factoryPrice;
    public float factoryF;
    public float factoryRound;
    public int factoryP = 20;

    public Text minePrice;
    public float mineF;
    public float mineRound;
    public int mineP = 5;



    void Start()
    {

      ScreenUpdatePrices();

      CurrencyF = 5;
      CurrencyRound = Mathf.RoundToInt(CurrencyF);
      Currency.text = "" + CurrencyRound;
    }

    public void ScreenUpdatePrices(){
      fishPrice.text = "" + fishP;
      woodPrice.text = "" + woodP;
      factoryPrice.text = "" + factoryP;
      minePrice.text = "" + mineP;
    }
    public void MultiplyPriceChange(float fac, float min, float log, float fis){
      factoryP = (int)(factoryP * fac);
      mineP = (int)(mineP * min);
      woodP = (int)(woodP * log);
      fishP = (int)(fishP * fis);
    }
    public void CalculateCurrency(){
      //TODO
    }
    void FixedUpdate()
    {
        GameObject Economic = GameObject.Find("EconomicStabilityBar");
        EconomicStability Econ = Economic.GetComponent<EconomicStability>();

        GameObject year = GameObject.Find("Currency");
        YearAndEvents yearScript = year.GetComponent<YearAndEvents>();

        if(yearScript.hasBeenClicked){
            CurrencyF += 5 * Time.deltaTime * ( Factories + Wood * 4 / 3 + Fish * 4 / 3 + Mines * 4 / 3) * (Econ.economicStabilityF * .01f);
        } else {
            CurrencyF += Time.deltaTime * ( Factories + Wood * 4 / 3 + Fish * 4 / 3 + Mines * 4 / 3) * (Econ.economicStabilityF * .01f);
        }
        CurrencyRound = Mathf.RoundToInt(CurrencyF);
        Currency.text = "" + CurrencyRound;

    }
    // Update is called once per frame
    void Update()
    {

    }
}
