using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class uimanagement : MonoBehaviour
{
    public GameObject optionsPanel;
    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);

    }

    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void  GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("inicio");
    }

    public void Quitgame()
    {
        Application.Quit();
       
    } 
   
       
}
