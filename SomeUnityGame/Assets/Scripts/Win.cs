using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject text4;
    public GameObject mus;
    float elapsedTime = 0.0f;
    public GameObject texte;
    public GameObject scrollend;
    public GameObject puppet;
    public GameObject puppet1;
    public GameObject puppet2;
    public GameObject puppet3;
    public GameObject puppet4;
    public GameObject puppet5;
    public GameObject puppet6;
    public GameObject puppet7;
    public GameObject puppet8;

    public GameObject bar;
    public GameObject Escape;
    public GameObject wall;
    public GameObject scrollsbk;

    public GameObject Poselenec;

    public GameObject Minecraft;
    public GameObject GameDisign;

    public static int scrolla = 0;

    public static bool book = false;
    private bool bookK = true;

    public static bool mapa = false;
    private bool mapasbk = true;
    private int scrollas;

    void Start()
    {
        text4.SetActive(false);
        scrollas = scrolla;
        mapa = false;
        scrolla = 0;
        wall.SetActive(true);
        puppet.SetActive(false);
        puppet1.SetActive(false);
        puppet2.SetActive(false);
        puppet3.SetActive(false);
        puppet4.SetActive(false);
        puppet5.SetActive(false);
        puppet6.SetActive(false);
        puppet7.SetActive(false);
        puppet8.SetActive(false);
        texte.SetActive(false);
        //.!.
        mus.SetActive(true);
        Escape.SetActive(false);
        scrollend.SetActive(false);
        bar.SetActive(true);
        scrollsbk.SetActive(false);
        Poselenec.SetActive(false);
        Minecraft.SetActive(false);
        GameDisign.SetActive(true);
    }
    void Update()
    {
        scrollas = scrolla;
        print(scrollas);
        if (mapa == true && mapasbk == true)
        {
            wall.SetActive(false);
            mapasbk = false;
        }
        if (scrolla == 11)
        {
            puppet8.SetActive(true);
            elapsedTime += Time.deltaTime;
            text4.SetActive(true);
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
            puppet5.SetActive(true);
        }
        if (scrolla == 2)
        {
            puppet6.SetActive(true);
        }
        if (scrolla == 4)
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
            mus.SetActive(false);
            scrollend.SetActive(true);
            puppet4.SetActive(true);
            puppet7.SetActive(true);
        }
    }


}

