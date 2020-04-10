﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continents : MonoBehaviour
{
    [SerializeField]
    private GameObject africa;
    [SerializeField]
    private GameObject north;
    [SerializeField]
    private GameObject south;
    [SerializeField]
    private GameObject aus;
    [SerializeField]
    private GameObject eur;

    private string SelectedContinent;
    void Start()
    {
      GameObject Cam = GameObject.Find("ContinentListeners");
      SelectContinent continentScript = Cam.GetComponent<SelectContinent>();
      SelectedContinent = continentScript.SelectedContinent;

      if(SelectedContinent != "Africa") {
        africa.layer = LayerMask.NameToLayer("AFRICA");
      }
      if(SelectedContinent != "North") {
        north.layer = LayerMask.NameToLayer("NORTHAMERICA");
      }
      if(SelectedContinent != "South") {
        south.layer = LayerMask.NameToLayer("SOUTHAMERICA");
      }
      if(SelectedContinent != "Australia") {
        aus.layer = LayerMask.NameToLayer("AUSTRALIA");
      }
      if(SelectedContinent != "Eurasia") {
        eur.layer = LayerMask.NameToLayer("EURASIA");
      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}