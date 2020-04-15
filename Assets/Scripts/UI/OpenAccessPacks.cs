using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAccessPacks : MonoBehaviour
{

    public GameObject store;
    public GameObject buyMoreTab;
    public bool status = true;

    void Start(){
        buyMoreTab.SetActive(false);
    }

    public void ShowAccessPacks(){
        status = !status;
        buyMoreTab.SetActive(status);
    }
}
