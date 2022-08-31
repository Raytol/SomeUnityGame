using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCAPE : MonoBehaviour
{
    public AudioSource WIN;
    public GameObject Escp;
    void OnTriggerEnter(Collider Roflan)
    {
        if (Roflan.name == "escpS")
        {
            print("123");
            WIN.Play();
            Escp.SetActive(true);
            Time.timeScale = 0;
            StartCoroutine(Test(5f));
        }
    }
    IEnumerator Test(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene(0);
    }
}

