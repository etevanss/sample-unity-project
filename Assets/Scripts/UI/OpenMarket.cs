using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMarket : MonoBehaviour
{
    public GameObject store;
    public bool status = true;

    void Start()
    {
        store.SetActive(false);
    }

    public void ShowMarket(){
        store.SetActive(!status);
        status = !status;
    }
}
