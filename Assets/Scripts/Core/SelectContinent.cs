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
  public string SelectedContinent;
  private bool HaveSelected = false;

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

            if (Eurasia.collider != null && !(HaveSelected)){
              Debug.Log("here");
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(7.856f, 3.166f, -10.0f);
                SelectedContinent = "Eurasia";
                HaveSelected = true;
            }
            if (North.collider != null && !(HaveSelected)){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(-8.5f, 1.360f, -10);
                SelectedContinent = "North";
                HaveSelected = true;
            }
            if (South.collider != null && !(HaveSelected)){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(-7.7f, -6.35f, -10);
                SelectedContinent = "South";
                HaveSelected = true;
            }
            if (Australia.collider != null && !(HaveSelected)){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(8.0f, -6.457f, -10);
                SelectedContinent = "Australia";
                HaveSelected = true;
            }
            if (Africa.collider != null && !(HaveSelected)){
                DontDestroyOnLoad(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ContinentPosition = new Vector3(1.384f, -3.5f, -10);
                SelectedContinent = "Africa";
                HaveSelected = true;
            }
        }
    }
}
