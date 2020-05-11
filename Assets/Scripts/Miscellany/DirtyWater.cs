using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyWater : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public float duration = 3.0F;
    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        GameObject Industry = GameObject.Find("industrialized");
        PercentIndustrialized Pct = Industry.GetComponent<PercentIndustrialized>();
        float t = Pct.percentF / 100;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
