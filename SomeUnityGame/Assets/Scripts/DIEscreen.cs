using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DIEscreen : MonoBehaviour
{
    public GameObject slide;
    public GameObject sounddie;
    public GameObject puppet;
    public GameObject sound;

    float elapsedTime = 0.0f;
    public GameObject diescreen;
    public Text ScrollsCountText;
    public Text TimeDieText;
    void Start()
    {
        ScrollsCountText.text = Win.scrolla.ToString() + "/11";
        TimeDieText.text = TimeManager.myText.text;
        diescreen.SetActive(false);
        sounddie.SetActive(false);
    }

    void Update()
    {
        slide.SetActive(false);
        puppet.SetActive(false);
        sound.SetActive(false); 
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 3.0f)
        {
            diescreen.SetActive(true);
            sounddie.SetActive(true);
            Cursor.visible = true;
        }
    }

    public void ReturnIntoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
