using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown(){
      Debug.Log("North!!!");
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      GameObject ContinentsObj = GameObject.Find("Countries");
      Continents Cont = ContinentsObj.GetComponent<Continents>();
        if (moneyScript.CurrencyF >= 1000)
        {
            moneyScript.CurrencyF -= 1000;
            Cont.ActivateNorth();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
