using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
	public GameObject topLeftPanel;
    public GameObject pausePanel;
	public GameObject store;
    public GameObject progressBars;
    public GameObject newsPanel;
    public GameObject newsLogPanel;
    public GameObject currentCurrencyPanel;
    public GameObject marketButton;
    public GameObject industrializedProgress;

    public void Start(){
        ResumeGame();
    }
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        topLeftPanel.SetActive(false);
		store.SetActive(false);
        progressBars.SetActive(false);
        newsPanel.SetActive(false);
        newsLogPanel.SetActive(false);
        currentCurrencyPanel.SetActive(false);
        marketButton.SetActive(false);
        industrializedProgress.SetActive(false);
        gameObject.GetComponent<AudioSource>().Stop();
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        topLeftPanel.SetActive(true);
		//store.SetActive(true);
        progressBars.SetActive(true);
        newsPanel.SetActive(true);
        currentCurrencyPanel.SetActive(true);
        marketButton.SetActive(true);
        industrializedProgress.SetActive(true);
        gameObject.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
    }
}
