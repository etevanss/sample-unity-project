using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectContinent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private LayerMask EURASIALayer;
    private LayerMask NORTHAMERICALayer;
    private LayerMask SOUTHAMERICALayer;
    private LayerMask AFRICALayer;
    private LayerMask AUSTRALIALayer;
    // Update is called once per frame
    private void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) //leftclick
        {
            if (Physics.Raycast(mousePos, Vector2.zero, MathF.Infinity, EURASIALayer)){
                PlayGame();
            }
            if (Physics.Raycast(mousePos, Vector2.zero, MathF.Infinity, NORTHAMERICALayer)){
                PlayGame();
            }
            if (Physics.Raycast(mousePos, Vector2.zero, MathF.Infinity, SOUTHAMERICALayer)){
                PlayGame();
            }
            if (Physics.Raycast(mousePos, Vector2.zero, MathF.Infinity, AFRICALayer)){
                PlayGame();
            }
            if (Physics.Raycast(mousePos, Vector2.zero, MathF.Infinity, AUSTRALIALayer)){
                PlayGame();
            }
        }
    }
}
