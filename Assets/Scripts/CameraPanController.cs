using UnityEngine;
using System.Collections;

public class CameraPanController : MonoBehaviour
{
    private Vector3 ResetCamera;
    private Vector3 Origin;
    private Vector3 Diference;
    private bool Drag = false;
    void Start()
    {
        ResetCamera = Camera.main.transform.position;
    }
    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Diference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if (Drag == false)
            {
                Drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            Drag = false;
        }
        if (Drag == true)
        {
            Camera.main.transform.position = Origin - Diference;
        }
        Camera.main.transform.position = new Vector3(
        Mathf.Clamp(Camera.main.transform.position.x, -24, 24),
        Mathf.Clamp(Camera.main.transform.position.y, -10, 10), Mathf.Clamp(Camera.main.transform.position.z, -10, 10));

        //RESET CAMERA TO STARTING POSITION WITH RIGHT CLICK
        if (Input.GetKeyDown("z"))
        {
            Camera.main.transform.position = ResetCamera;
        }
    }
}