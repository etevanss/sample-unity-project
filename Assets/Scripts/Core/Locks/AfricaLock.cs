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
      GameObject ContinentsObj = GameObject.Find("Countries");
      Continents Cont = ContinentsObj.GetComponent<Continents>();
      Cont.ActivateAfrica();
      Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
