using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject panelMenuPause;
    [SerializeField] GameObject panelMainMenu;
    [SerializeField] GameObject panelEndMenu;
    [SerializeField] String reloadScene;
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
    }
    public void LoadMainMenu()
    {
        panelMainMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnloadMainMenu()
    {
        panelMainMenu.gameObject.SetActive(false);
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
        panelEndMenu.gameObject.SetActive(true);
    }

    public void UnloadEndMenu()
    {
        panelEndMenu.gameObject.SetActive(false);
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
