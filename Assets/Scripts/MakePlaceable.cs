using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlaceable : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;
    private Vector3 mousePos;

    [SerializeField]
    private LayerMask BGLayer;

    [SerializeField]
    private LayerMask ICONLayer;


    public bool hasStarted;
    public int numOfFacs = 10;

    void Start()
    {
        if(hasStarted == false)
        {
          numOfFacs = 0;
        }
    }

    void Update()
    {


        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//get mouse pos
        transform.position = new Vector3(mousePos.x, mousePos.y, -1);//put object on mouse, -1 z for layering; could be vector 2 otherwise

        if(Input.GetMouseButtonDown(0)) //leftclick
        {
          
          RaycastHit2D landHit = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,BGLayer);
          //is mouse on continent
          RaycastHit2D iconHit = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,ICONLayer);
          
          //is mouse on icon
          if (iconHit.collider == null && landHit.collider != null) {
            Instantiate(finalObject, transform.position, Quaternion.identity);
            //create final object, at mouse position, maintain rotation
            numOfFacs++;
            hasStarted = true;
            Debug.Log(numOfFacs);
          }

        } else if (Input.GetMouseButtonDown(1)) { //right click
			  Cursor.visible = true;
          Destroy(this.gameObject); //remove spawner from mouse
        }
    }
}
