using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject wall;
    public GameObject scrollsbk;

    public static int scrolla = 0;

    public static bool book = false;
    private bool bookK = true;

    public static bool mapa = false;
    private bool mapasbk = true;

    void Start()
    {

    }
    void Update()
    {
        if (mapa == true && mapasbk == true)
        {
            wall.SetActive(false);
            mapasbk = false;
        }
        if (scrolla == 1)
        {

        }
        if (book == true && bookK == true)
        {
            print("1");
            scrollsbk.SetActive(true);
            bookK = false;
        }
    }


}

