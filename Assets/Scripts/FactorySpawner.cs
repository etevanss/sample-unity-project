using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawner : MonoBehaviour
{
  [SerializeField]
  public GameObject sampleObject;

  public GameObject[] factorySpawners;

public void AddObject()
{
    factorySpawners = GameObject.FindGameObjectsWithTag("FactorySpawner");
    //So basically what we're doing here is deleting all the other spawners that
    //are on the screen when we click a spawner button.
    //make sure all spawners are tagged as such ^ or they wont get deleted
    foreach(GameObject placer in factorySpawners){
      GameObject.Destroy(placer);
    }
	   Cursor.visible = false;
    Instantiate(sampleObject); //make the new spawner

}
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
