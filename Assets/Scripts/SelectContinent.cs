using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectContinent : MonoBehaviour
{
  [SerializeField]
  private LayerMask EURASIALayer;
  [SerializeField]
  private LayerMask NORTHAMERICALayer;
  [SerializeField]
  private LayerMask SOUTHAMERICALayer;
  [SerializeField]
  private LayerMask AFRICALayer;
  [SerializeField]
  private LayerMask AUSTRALIALayer;

  private Vector3 mousePos;

    // Update is called once per frame
    private void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) //leftclick
        {
            RaycastHit2D Eurasia = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,EURASIALayer);
            RaycastHit2D Africa = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,AFRICALayer);
            RaycastHit2D North = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,NORTHAMERICALayer);
            RaycastHit2D South = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,SOUTHAMERICALayer);
            RaycastHit2D Australia = Physics2D.Raycast(mousePos,Vector2.zero, Mathf.Infinity,AUSTRALIALayer);

            if (Eurasia.collider != null){
              Debug.Log("here");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
            if (North.collider != null){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (South.collider != null){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (Australia.collider != null){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (Africa.collider != null){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
