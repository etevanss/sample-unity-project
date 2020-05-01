using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakePlaceable : MonoBehaviour
{
    [SerializeField]
    private GameObject finalObject;
    private Vector3 mousePos;

    [SerializeField]
    private LayerMask BGLayer;

    [SerializeField]
    private LayerMask ICONLayer;

    [SerializeField]
    private string linkedCount;

    public int price;
    private bool placeable = true;

    void Start()
    {
      DrawBoundaries();
    }

    void DrawBoundaries(){
      GameObject[] Boundaries = GameObject.FindGameObjectsWithTag ("Boundary");
      foreach(GameObject bound in Boundaries) {
        Debug.Log(Boundaries.Length);
        SpriteRenderer sr = bound.GetComponent<SpriteRenderer>();
        sr.enabled = true;
    }
  }
    void EraseBoundaries(){
      GameObject[] Boundaries = GameObject.FindGameObjectsWithTag ("Boundary");
      foreach(GameObject bound in Boundaries) {
        Debug.Log(Boundaries.Length);
        SpriteRenderer sr = bound.GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }
  }
    void UpdateCount(){
      GameObject MoneyListener = GameObject.Find("Money Listener");
      Money moneyScript = MoneyListener.GetComponent<Money>();
      if(linkedCount == "Factories") {
        moneyScript.Factories++;
      } else if (linkedCount == "Mines") {
        moneyScript.Mines++;
      } else if (linkedCount == "Fish") {
        moneyScript.Fish++;
      } else if (linkedCount == "Wood") {
        moneyScript.Wood++;
      }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("HERE");
        placeable = false;
      //  Destroy(gameObject);
        Transform tf = gameObject.transform;
        Transform circle = tf.Find("Circle");
        SpriteRenderer sr = circle.GetComponent<SpriteRenderer>();
        sr.color = new Color(1f, 0f, 0f, 1f);

    }
    private void OnTriggerExit2D(Collider2D other){
      //Debug.Log("THERE");
      placeable= true;
      Transform tf = gameObject.transform;
      Transform circle = tf.Find("Circle");
      SpriteRenderer sr = circle.GetComponent<SpriteRenderer>();
      sr.color = new Color(1f, 1f, 1f, 1f);
    }


    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//get mouse pos
        transform.position = new Vector3(mousePos.x, mousePos.y, -1);//put object on mouse, -1 z for layering; could be vector 2 otherwise

        GameObject MoneyListener = GameObject.Find("Money Listener");
        Money moneyScript = MoneyListener.GetComponent<Money>();


        //Debug.Log(moneyScript.CurrencyF);


        if(Input.GetMouseButtonDown(0)) //leftclick
        {

          RaycastHit2D landHit = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,BGLayer);
          //is mouse on continent
          RaycastHit2D iconHit = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,ICONLayer);
          //is mouse on icon

          if(placeable && landHit.collider != null){

            if (finalObject.name == "Factory Instance" && moneyScript.CurrencyF >= moneyScript.factoryP) {
              moneyScript.CurrencyF -= moneyScript.factoryP;
              moneyScript.Currency.text = "" + moneyScript.CurrencyF;
              Instantiate(finalObject, transform.position, Quaternion.identity);
              //create final object, at mouse position, maintain rotation
              DrawBoundaries();
              UpdateCount();
              moneyScript.MultiplyPriceChange(1.25f,1.0f,1.0f,1.0f);
              moneyScript.ScreenUpdatePrices();

            } else if (finalObject.name == "Fish Instance" && moneyScript.CurrencyF >= moneyScript.fishP) {
              moneyScript.CurrencyF -= moneyScript.fishP;
              moneyScript.Currency.text = "" + moneyScript.CurrencyF;
              Instantiate(finalObject, transform.position, Quaternion.identity);

              DrawBoundaries();
              UpdateCount();
              moneyScript.MultiplyPriceChange(1.0f,1.0f,1.0f,1.25f);
              moneyScript.ScreenUpdatePrices();

            } else if (finalObject.name == "Log Instance" && moneyScript.CurrencyF >= moneyScript.woodP) {
              moneyScript.CurrencyF -= moneyScript.woodP;
              moneyScript.Currency.text = "" + moneyScript.CurrencyF;
              Instantiate(finalObject, transform.position, Quaternion.identity);

              DrawBoundaries();
              UpdateCount();
              moneyScript.MultiplyPriceChange(1.0f,1.0f,1.25f,1.0f);
              moneyScript.ScreenUpdatePrices();

            } else if (finalObject.name == "Mine Instance" && moneyScript.CurrencyF >= moneyScript.mineP) {
              moneyScript.CurrencyF -= moneyScript.mineP;
              moneyScript.Currency.text = "" + moneyScript.CurrencyF;
              Instantiate(finalObject, transform.position, Quaternion.identity);

              DrawBoundaries();
              UpdateCount();
              moneyScript.MultiplyPriceChange(1.0f,1.25f,1.0f,1.0f);
              moneyScript.ScreenUpdatePrices();
            }

          }


        } else if (Input.GetMouseButtonDown(1)) { //right click
          Destroy(this.gameObject); //remove spawner from mouse
           Cursor.visible = true;
           EraseBoundaries();
        }

    }
}
