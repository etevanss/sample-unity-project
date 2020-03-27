using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int Currency = 0, Fish = 0, Wood = 0, Factories = 0, Mines = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate(){
    Currency += Factories;
    Debug.Log(Currency);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
