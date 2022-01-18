using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uimanagementinicio : MonoBehaviour
{
    public GameObject optionsPanel;
    public void OptionsPanel()
    {

        optionsPanel.SetActive(true);
    }

    public void GoToCredits()
    {
       
        SceneManager.LoadScene("creditos");
    }


    public void  GoToGame()
    {
        
        SceneManager.LoadScene("parcial1");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
