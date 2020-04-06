using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomController : MonoBehaviour
{
    private float ResetCamera;
    // Start is called before the first frame update
    private Camera cam;
    private float targetZoom;
    //sensitivity to scroll wheel... used to make camera zoom look smoother... used 3 for now we will need to see what looks best
    private float zoomFactor = 3f;
    private float zoomLerpSpeed = 10;

    void Start()
    {
        ResetCamera = 7.5f;
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float scrollData;
        //get mouse wheel input
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= (scrollData * zoomFactor);
        //Clamp prevents camera from zooming way too far in and way too far out
        targetZoom = Mathf.Clamp(targetZoom, 2.5f, 15f);
        //Lerp is just linear interpolation and gets a point within a given distance
        //between the starting position and ending position
        //in this case orthographic size and the target zoom
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
    void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
          //  targetZoom = ResetCamera;
        }
    }
}
