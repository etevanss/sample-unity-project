using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentPositionListener : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject Cam = GameObject.Find("ContinentListeners");
        SelectContinent continentScript = Cam.GetComponent<SelectContinent>();
        Camera.main.transform.position = continentScript.ContinentPosition;
        Debug.Log(continentScript.ContinentPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
