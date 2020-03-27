using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySelector : MonoBehaviour
{
  [SerializeField]
  private GameObject finalObject;
  private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
