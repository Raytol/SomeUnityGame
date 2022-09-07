using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject scrollend;
    public GameObject puppet;
    public GameObject puppet1;
    public GameObject puppet2;
    public GameObject puppet3;
    public GameObject puppet4;

    public GameObject bar;
    public GameObject Escape;
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
        if (scrolla == 11)
        {
            wall.SetActive(false);
            Escape.SetActive(true);

        }
        if (book == true && bookK == true)
        {
            bar.SetActive(false);
            scrollsbk.SetActive(true);
            bookK = false;
        }
        if (scrolla == 1)
        {
            puppet.SetActive(true);
        }
        if (scrolla == 3)
        {
            puppet1.SetActive(true);
        }
        if (scrolla == 6)
        {
            puppet2.SetActive(true);
        }
        if (scrolla == 8)
        {
            puppet3.SetActive(true);
        }
        if (scrolla == 10)
        {
            scrollend.SetActive(true);
            puppet4.SetActive(true);
        }
    }


}

