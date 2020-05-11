using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AusLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown()
    {
        Debug.Log("AUSTRALIA");
        GameObject MoneyListener = GameObject.Find("Money Listener");
        Money moneyScript = MoneyListener.GetComponent<Money>();
        GameObject ContinentsObj = GameObject.Find("Countries");
        Continents Cont = ContinentsObj.GetComponent<Continents>();
        if (moneyScript.CurrencyF >= 500)
        {
            moneyScript.CurrencyF -= 500;
            Cont.ActivateAus();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
