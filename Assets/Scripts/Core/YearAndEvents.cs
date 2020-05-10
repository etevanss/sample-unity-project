using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YearAndEvents : MonoBehaviour
{

    public GameObject globalEventPanel;
    public GameObject topLeftPanel;
	public GameObject store;
    public GameObject progressBars;
    public GameObject newsPanel;
    public GameObject newsLogPanel;

    public Text yearText;
    public float yearFloat = 1800;
    public float year;

    public Button fastForwardButton;
    public bool hasBeenClicked = false;
    public bool isFF = false;

    public Text eventTitle;
    public Text eventBodyText;

    public Text newsLogText;

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

        // EARLY GAME EVENTS (before 1950)
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
        earlyGameDescList.Add("Logging facilities, farms, and mines will now produce more money. Happy trucking!");

        // LATE GAME EVENTS (after 1950)
        lateGameTitleList.Add("Hot, dry climate results in global forest fires");
        lateGameTitleList.Add("Global climate change has shifted optimal harvesting periods");
        lateGameTitleList.Add("Severe air pollution has increased respiratory illness prevalence worldwide");
        lateGameTitleList.Add("Rapid industrial pollution causes overuse of natural resources");
        lateGameTitleList.Add("Soil pollution has severely stunted the growth of agriculture and food industries");

        lateGameDescList.Add("Forest fires across the world have stunted the logging industry. All logging industries have gone out of operation.");
        lateGameDescList.Add("Crops now have shorter harvesting periods due to climate changes. All farming industries will produce less money.");
        lateGameDescList.Add("Hospitals are filled with immunocomprimised patients and thus productivity decreased. All industries will produce less money.");
        lateGameDescList.Add("Resources are now more scarce. All industries will cost more money to place.");
        lateGameDescList.Add("Food and farming are now far more scarce and valued. All industries will produce less money and farms will cost more money to place.");
    }

    void Update()
    {
        Debug.Log(isFF);
        if(hasBeenClicked)
        {
            isFF = true;
            UpdateYearFastForwardUI();
        } else {
            isFF = false;
            UpdateYearUI();
        }

        GameObject percent = GameObject.Find("Percent");
        PercentIndustrialized percentScript = percent.GetComponent<PercentIndustrialized>();

        GameObject stability = GameObject.Find("Stability");
        EconomicStability stabilityScript = stability.GetComponent<EconomicStability>();

        GameObject MoneyListener = GameObject.Find("Money Listener");
        Money moneyScript = MoneyListener.GetComponent<Money>();

        
        if(stabilityScript.economicStabilityF <= 35.0 || moneyScript.CurrencyF < 0.0) {
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Cursor.visible = true;
        }
        

        if(year == 2100 || percentScript.percentF >= 100.0){ // ends game at year 2100 or if world fully industrialized
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Cursor.visible = true;
        }
    


    }

    IEnumerator OpenGlobalEventPanel(){
        while(yearFloat <= 2100){
            yield return new WaitForSeconds(Random.Range(30, 50));
            //yield return new WaitForSeconds(5);

            globalEventPanel.SetActive(true);
            topLeftPanel.SetActive(false);
            store.SetActive(false);
            progressBars.SetActive(false);
            newsPanel.SetActive(false);
            newsLogPanel.SetActive(false);
            Time.timeScale = 0;
            EditGlobalEventDesc();
        }
    }

    void EditGlobalEventDesc(){

        GameObject MoneyListener = GameObject.Find("Money Listener");
        Money moneyScript = MoneyListener.GetComponent<Money>();

        int randNum = Random.Range(0, earlyGameTitleList.Count);
        int randNum2 = Random.Range(0, lateGameTitleList.Count);
        
        if(year < 1950){
            eventTitle.text = earlyGameTitleList[randNum];
            eventBodyText.text = earlyGameDescList[randNum];
        } else {
            eventTitle.text = lateGameTitleList[randNum2];
            eventBodyText.text = lateGameDescList[randNum2];
        }

        //newsLogText.text += "\n" + year + ": " + earlyGameTitleList[randNum] + "\n";

        if(year < 1950){
            if(earlyGameTitleList[randNum].IndexOf("A world war has erupted!") >= 0){
                moneyScript.MultiplyPriceChange(2.0f, 2.0f, 2.0f, 2.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(earlyGameTitleList[randNum].IndexOf("Efficient railway systems have been deployed") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 0.5f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(earlyGameTitleList[randNum].IndexOf("A global pandemic has ravaged industry worldwide") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(earlyGameTitleList[randNum].IndexOf("The world has entered an economic depression") >= 0){
                moneyScript.MultiplyPriceChange(3.0f, 3.0f, 3.0f, 3.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(earlyGameTitleList[randNum].IndexOf("The assembly line takes the world by storm!") >= 0){
                moneyScript.MultiplyPriceChange(0.75f, 0.75f, 0.75f, 0.75f);
                moneyScript.ScreenUpdatePrices();
            } else if(earlyGameTitleList[randNum].IndexOf("The commercial shipping container revolutionizes industry") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            }
        } else {
            if(lateGameTitleList[randNum].IndexOf("Hot, dry climate results in global forest fires") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(lateGameTitleList[randNum].IndexOf("Global climate change has shifted optimal harvesting periods") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(lateGameTitleList[randNum].IndexOf("Severe air pollution has increased respiratory illness prevalence worldwide") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(lateGameTitleList[randNum].IndexOf("Rapid industrial pollution causes overuse of natural resources") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            } else if(lateGameTitleList[randNum].IndexOf("Soil pollution has severely stunted the growth of agriculture and food industries") >= 0){
                moneyScript.MultiplyPriceChange(1.0f, 1.0f, 1.0f, 1.0f);
                moneyScript.ScreenUpdatePrices();
            }
        }

        //earlyGameTitleList.RemoveAt(randNum);
        //earlyGameDescList.RemoveAt(randNum);
    }

    public void ExitPopUp()
    {
        Time.timeScale = 1;
        globalEventPanel.SetActive(false);
        topLeftPanel.SetActive(true);
		store.SetActive(true);
        progressBars.SetActive(true);
        newsPanel.SetActive(true);
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
