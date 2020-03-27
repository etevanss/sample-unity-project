using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{

    public GameObject globalEventPanel;
    public GameObject topLeftPanel;
	public GameObject store;

    public Text yearText;
    public float yearFloat = 1800;
    public float year;

    public Button fastForwardButton;
    public bool hasBeenClicked = false;

    void Start()
    {
        Button btn = fastForwardButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        globalEventPanel.SetActive(false);
    }

    void Update()
    {
        if(hasBeenClicked)
        {
            UpdateYearFastForwardUI();
        } else {
            UpdateYearUI();
        }

        if(yearText.text == "" + 1850)  // global event in 1850
        {
            globalEventPanel.SetActive(true);
            topLeftPanel.SetActive(false);
			store.SetActive(false);
            Time.timeScale = 0;
            
            Debug.Log(yearText.text);
        }
    }

    public void TaskOnClick()
    {
        hasBeenClicked = !hasBeenClicked;
    }

    public void UpdateYearUI()
    {
        yearFloat += Time.deltaTime * 1/2; //one year = 2 seconds
        year = Mathf.RoundToInt(yearFloat);
        yearText.text = "" + year;
    }

    public void UpdateYearFastForwardUI()
    {
        yearFloat += Time.deltaTime * 1/2 * 5; //5 year = 2 seconds
        year = Mathf.RoundToInt(yearFloat);
        yearText.text = "" + year;
    }

    public void ExitPopUp()
    {
        Time.timeScale = 1;
        globalEventPanel.SetActive(false);
        topLeftPanel.SetActive(true);
		store.SetActive(true);
        
        //Debug.Log(yearText.text);
        //TODO: Doesnt exit pop-up because it is caught in Update() method continually and will never fully enter ExitPopUp()
    }
}
