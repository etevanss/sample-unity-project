using System.Collections;
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

    public GameObject africaLock;
    public GameObject northLock;
    public GameObject southLock;
    public GameObject ausLock;
    public GameObject eurLock;


    private string SelectedContinent;
    void Start()
    {
      GameObject Cam = GameObject.Find("ContinentListeners");
      SelectContinent continentScript = Cam.GetComponent<SelectContinent>();
      SelectedContinent = continentScript.SelectedContinent;

      africaLock.SetActive(true);
      northLock.SetActive(true);
      southLock.SetActive(true);
      ausLock.SetActive(true);
      eurLock.SetActive(true);

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

      if(SelectedContinent == "Africa") {
        ActivateAfrica();
        africaLock.SetActive(false);
      }
      if(SelectedContinent == "North") {
        ActivateNorth();
        northLock.SetActive(false);
      }
      if(SelectedContinent == "South") {
        ActivateSouth();
        southLock.SetActive(false);
      }
      if(SelectedContinent == "Australia") {
        ActivateAus();
        ausLock.SetActive(false);
      }
      if(SelectedContinent == "Eurasia") {
        ActivateEur();
        eurLock.SetActive(false);
      }

    }

    public void ActivateAfrica(){
      Debug.Log("lock pressed");
      africa.layer = LayerMask.NameToLayer("BG");
      GameObject Boundary = GameObject.Find("Africa Boundary");
      Destroy(Boundary);
    }
    public void ActivateNorth(){
      north.layer = LayerMask.NameToLayer("BG");
      GameObject Boundary = GameObject.Find("North Boundary");
      Destroy(Boundary);
    }
    public void ActivateSouth(){
      south.layer = LayerMask.NameToLayer("BG");
      GameObject Boundary = GameObject.Find("South Boundary");
      Destroy(Boundary);
    }
    public void ActivateEur(){
      eur.layer = LayerMask.NameToLayer("BG");
      GameObject Boundary = GameObject.Find("Eurasia Boundary");
      Destroy(Boundary);
    }
    public void ActivateAus(){
      aus.layer = LayerMask.NameToLayer("BG");
      GameObject Boundary = GameObject.Find("Australia Boundary");
      Destroy(Boundary);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
