using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenNewsLog : MonoBehaviour
{
    public GameObject newsLogPanel;
    public bool status = true;

    void Start(){
        newsLogPanel.SetActive(false);
    }

    public void ShowNewsLog(){
        
        newsLogPanel.SetActive(status);
        status = !status;
    }
}
