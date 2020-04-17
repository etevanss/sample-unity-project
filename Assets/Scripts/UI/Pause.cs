﻿using System.Collections;
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
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        topLeftPanel.SetActive(true);
		store.SetActive(true);
        progressBars.SetActive(true);
        newsPanel.SetActive(true);
        Time.timeScale = 1;
    }
}
