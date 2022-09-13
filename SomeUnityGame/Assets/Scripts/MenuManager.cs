using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    private bool lobbysee = false;
    public GameObject lobby;
    public GameObject bebes;
    public GameObject tips;
    public bool gamem = false;
    public GameObject Gamemode;

    public GameObject Question;
    public GameObject LoadingScreen;
    public Slider Bar;
    public TMP_Text ProgressText;
    public GameObject Controls;
    public bool ControlsIsActive = false;
    void Start()
    {
        lobby.SetActive(false);
        bebes.SetActive(true);
        tips.SetActive(false);
    }
    public void Play()
    {
        LoadingScreen.SetActive(true);
        //SceneManager.LoadScene(1);
        StartCoroutine(LoadAsync());
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            Bar.value = asyncLoad.progress+10;
            ProgressText.text = (asyncLoad.progress*1000/1000*100+10) + "%";

            if (asyncLoad.progress >= .9f && !asyncLoad.allowSceneActivation)
            {
                Question.SetActive(true);
                if (Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }

    public void ControlsActive()
    {
        ControlsIsActive = !ControlsIsActive;
        if (ControlsIsActive)
        {
            Controls.SetActive(true);
        }
        else
        {
            Controls.SetActive(false);
        }
    }
    public void GameMode()
    {
        gamem = !gamem;
        if (gamem)
        {
            Gamemode.SetActive(true);
        }
        else
        {
            Gamemode.SetActive(false);
        }
    }
    public void tipss()
    {
        tips.SetActive(true);
        bebes.SetActive(false);
    }
    public void online()
    {
        if (lobbysee == false)
        {
            lobby.SetActive(true);
            lobbysee = true;
        }
        else
        {
            lobby.SetActive(false);
            lobbysee = false;
        }
    }
}
