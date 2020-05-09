using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EurLock : MonoBehaviour
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
        if (moneyScript.CurrencyF >= 1500)
        {
            moneyScript.CurrencyF -= 1500;
            Cont.ActivateEur();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
