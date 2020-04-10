using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject Cam = GameObject.Find("ContinentListeners");
        //SelectContinent continentScript = Cam.GetComponent<SelectContinent>();
        //GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sortingLayerName = sortingLayerName;
        Debug.Log(gameObject.name);
        //VisualEffect ps = gameObject.GetComponent<VisualEffect>();
        Renderer r = gameObject.GetComponent<Renderer>();
        r.sortingLayerName = "Top";
        r.sortingOrder = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
