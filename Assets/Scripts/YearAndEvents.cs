using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearAndEvents : MonoBehaviour
{

    public GameObject globalEventPanel;
    public GameObject topLeftPanel;
	public GameObject store;

    public Text yearText;
    public float yearFloat = 1800;
    public float year;

    public Button fastForwardButton;
    public bool hasBeenClicked = false;


    public Text eventTitle;
    public Text eventBodyText;

    List<string> earlyGameTitleList = new List<string>();
    List<string> earlyGameDescList = new List<string>();
    List<string> lateGameTitleList = new List<string>();
    List<string> lateGameDescList = new List<string>();



    void Start()
    {
        Button btn = fastForwardButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        globalEventPanel.SetActive(false);

        StartCoroutine(OpenGlobalEventPanel());

        earlyGameTitleList.Add("1");
        earlyGameTitleList.Add("2");
        earlyGameTitleList.Add("3");
        earlyGameTitleList.Add("4");
        earlyGameTitleList.Add("5");
        earlyGameDescList.Add("1 Description");
        earlyGameDescList.Add("2 Description");
        earlyGameDescList.Add("3 Description");
        earlyGameDescList.Add("4 Description");
        earlyGameDescList.Add("5 Description");
    }

    void Update()
    {
        if(hasBeenClicked)
        {
            UpdateYearFastForwardUI();
        } else {
            UpdateYearUI();
        }

    }

    IEnumerator OpenGlobalEventPanel(){
        while(yearFloat <= 2100){
            yield return new WaitForSeconds(5);

            globalEventPanel.SetActive(true);
            topLeftPanel.SetActive(false);
            store.SetActive(false);
            Time.timeScale = 0;
            EditGlobalEventDesc();
        }
        
    }

    void EditGlobalEventDesc(){
        int randNum = Random.Range(0, earlyGameTitleList.Count);

        eventTitle.text = earlyGameTitleList[randNum];
        eventBodyText.text = earlyGameDescList[randNum];

        earlyGameTitleList.RemoveAt(randNum);
        earlyGameDescList.RemoveAt(randNum);
    }

    public void ExitPopUp()
    {
        Time.timeScale = 1;
        globalEventPanel.SetActive(false);
        topLeftPanel.SetActive(true);
		store.SetActive(true);
    }
    
    public void YearInc(){
        year++;
        yearText.text = "" + year;
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

}
