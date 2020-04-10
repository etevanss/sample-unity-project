using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearAndEvents : MonoBehaviour
{

    public GameObject globalEventPanel;
    public GameObject topLeftPanel;
	  public GameObject store;
    //public GameObject fadeOutPanel;

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

        earlyGameTitleList.Add("A world war has erupted!");
        earlyGameTitleList.Add("Efficient railway systems have been deployed");
        earlyGameTitleList.Add("A global pandemic has ravaged industry worldwide");
        earlyGameTitleList.Add("The world has entered an economic depression");
        earlyGameTitleList.Add("The assembly line takes the world by storm!");
        earlyGameTitleList.Add("The commercial shipping container revolutionizes industry");

        earlyGameDescList.Add("All tools of industrialization will cost more until the war has ended. Be frugal!");
        earlyGameDescList.Add("Mines now cost less and produce more money. Take advantage of this innovation!");
        earlyGameDescList.Add("All industries will produce less money until the pandemic has ended. Stay safe and wash your hands!");
        earlyGameDescList.Add("All industries will produce less money and cost more to place.");
        earlyGameDescList.Add("All industries benefit from this invention by increasing production. Keep rolling in the money!");
        earlyGameDescList.Add("Logging facilities, fisheries, and mines will now produce more money. Happy trucking!");


        lateGameTitleList.Add("Overfishing and pollution continue to decimate fisheries");
        lateGameTitleList.Add("Hot, dry climate results in global forest fires");

        lateGameDescList.Add("Salmon, scad, and lobster have become globally extinct due to overfishing and polluted ecosystems. All fisheries have gone out of operation.");
        lateGameDescList.Add("Forest fires across the world have stunted the logging industry. All logging industries have gone out of operation.");
    }

    void Update()
    {
        if(hasBeenClicked)
        {
            UpdateYearFastForwardUI();
        } else {
            UpdateYearUI();
        }

        /*
        if(yearFloat == 1805){
            Debug.Log("wtf");
            Color color = fadeOutPanel.GetComponent<MeshRenderer>().material.color;
            while(color.a < 1){
                color.a += 0.5f;
                fadeOutPanel.GetComponent<MeshRenderer>().material.color = color;
            }
        }
        */


    }

    IEnumerator OpenGlobalEventPanel(){
        while(yearFloat <= 2100){
            yield return new WaitForSeconds(Random.Range(30, 50));

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
        yearFloat += Time.deltaTime * 1/2 * 5; //5 years = 2 seconds
        year = Mathf.RoundToInt(yearFloat);
        yearText.text = "" + year;
    }

}
