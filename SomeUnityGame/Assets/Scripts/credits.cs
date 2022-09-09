using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;

    public GameObject ax;
    public GameObject b;
    
    public int aa = 500;
    public int a = 0;
    private float y = 2f;
    public GameObject credit;
    void Start()
    {
        
    }
    void Update()
    {
        if (a < aa)
        {
            credit.transform.Translate(0, y, 0);
            a = a + 1;
        }
        if (a <= 450)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
        ax.SetActive(false);
        b.SetActive(false);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);
    }
}
