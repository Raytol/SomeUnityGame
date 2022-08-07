using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsmenu;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
    public void Settings()
    {
        menu.SetActive(false);
        settingsmenu.SetActive(true);
    }

    public void Return()
    {
        menu.SetActive(true);
        settingsmenu.SetActive(false);
    }
}
