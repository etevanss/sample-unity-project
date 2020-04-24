using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMarket : MonoBehaviour
{
    public GameObject store;
    public GameObject newsPanel;
    public bool status = true;

    void Start()
    {
        store.SetActive(false);
        newsPanel.SetActive(false);
    }

    public void ShowMarket(){
        store.SetActive(status);
        status = !status;
    }
}
