using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject Question;
    public GameObject LoadingScreen;
    public Slider Bar;
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
            Bar.value = asyncLoad.progress;

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
}
