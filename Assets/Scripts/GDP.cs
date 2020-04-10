using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GDP : MonoBehaviour
{
    public float GDProduct = 1.2f;
    private float A = .47f;
    private float B = 1.023f;
    public Text GlobalGDP;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      GameObject Year = GameObject.Find("Canvas");
      YearAndEvents YearScript = Year.GetComponent<YearAndEvents>();

      GDProduct = A * Mathf.Pow(B, (YearScript.year - 1800 ));
      GDProduct = Mathf.Round(GDProduct * 100f) / 100f;
      GlobalGDP.text = "Global GDP: " + GDProduct + " trillion $";
    }
}
