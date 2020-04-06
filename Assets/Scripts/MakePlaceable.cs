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

    [SerializeField]
    private int price;


    void Start()
    {

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
    // Update is called once per frame
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


          if(iconHit.collider == null && landHit.collider != null && moneyScript.CurrencyF >= price) {
              moneyScript.CurrencyF -= price;
              moneyScript.Currency.text = "" + moneyScript.CurrencyF;


              if (iconHit.collider == null && landHit.collider != null) {

                Instantiate(finalObject, transform.position, Quaternion.identity);
                //create final object, at mouse position, maintain rotation
                UpdateCount();

              }

          }

        } else if (Input.GetMouseButtonDown(1)) { //right click
          Destroy(this.gameObject); //remove spawner from mouse
           Cursor.visible = true;
        }

    }
}
