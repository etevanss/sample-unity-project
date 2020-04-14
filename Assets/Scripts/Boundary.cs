using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HERE");
      //  Destroy(gameObject);
        Transform tf = gameObject.transform;
        Transform circle = tf.Find("Circle");
        SpriteRenderer sr = circle.GetComponent<SpriteRenderer>();
        sr.color = new Color(1f, 0f, 0f, 1f);

    }
    private void OnTriggerExit2D(Collider2D other){
      Debug.Log("THERE");
      Transform tf = gameObject.transform;
      Transform circle = tf.Find("Circle");
      SpriteRenderer sr = circle.GetComponent<SpriteRenderer>();
      sr.color = new Color(1f, 1f, 1f, 1f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
