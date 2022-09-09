using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public GameObject ax;
    public GameObject b;
    public GameObject c;
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
        c.SetActive(false);
    }
}
