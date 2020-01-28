using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject panelMenuPause;
    [SerializeField] GameObject panelMainMenu;
    [SerializeField] GameObject panelEndMenu;
    [SerializeField] TextMeshProUGUI P1Lives;
    [SerializeField] TextMeshProUGUI P2Lives;
    [SerializeField] String reloadScene;
    [SerializeField] PlayerController playerController;
    [SerializeField] ClickToMove clickToMove;
    void Start()
    {
        LoadMainMenu();
        Time.timeScale = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelMenuPause.activeSelf)
            {
                UnloadMenuPause();
            }
            else
            {
                LoadMenuPause();
            }
        }

        if(playerController.GetPlayer1Health() < 1)
        {
            LoadEndMenu(); 
            //Have to specify who the winner is, implement change text like "player2 win"
        }

        if(clickToMove.GetPlayer2Health() < 1)
        {
            LoadEndMenu();
            //Have to specify who the winner is, implement change text like "player1 win"
        }
    }
    public void LoadMainMenu()
    {
        panelMainMenu.gameObject.SetActive(true);
        P1Lives.gameObject.SetActive(false);
        P2Lives.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    public void UnloadMainMenu()
    {
        panelMainMenu.gameObject.SetActive(false);
        P1Lives.gameObject.SetActive(true);
        P2Lives.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    public void LoadMenuPause()
    {
        panelMenuPause.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnloadMenuPause()
    {
        panelMenuPause.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void LoadEndMenu()
    {
        P1Lives.gameObject.SetActive(false);
        P2Lives.gameObject.SetActive(false);
        panelEndMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnloadEndMenu()
    {
        panelEndMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void Reload()
    {
        SceneManager.LoadScene(reloadScene);
    }
}
