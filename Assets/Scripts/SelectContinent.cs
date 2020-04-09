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
  public Vector3 ContinentPosition;
  private Vector3 mousePos;

    // Update is called once per frame
    private void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator CameraCoroutine()
    {
        yield return new WaitForSeconds(30);
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
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(3.856f, 1.666f, -10.0f);
            }
            if (North.collider != null){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(-4.0f, 1.360f, -10);
            }
            if (South.collider != null){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(-3.445f, -2.309f, -10);
            }
            if (Australia.collider != null){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(4.0f, -2.457f, -10);
            }
            if (Africa.collider != null){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(.509f, -.759f, -10);
            }
        }
    }
}
