using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuDIF : MonoBehaviour
{
    private bool show = false;
    public GameObject menus;

    public GameObject Legacy;
    public GameObject Standart;
    void Update()
    {
        if (Player_Move.easy == true)
        {
            Legacy.SetActive(false);
            Standart.SetActive(true);
        }
        else if (Player_Move.easy == false)
        {
            Legacy.SetActive(true);
            Standart.SetActive(false);
        }
    }
    public void hardest()
    {
        Player_Move.easy = false;
    }
    public void ezest()
    {
        Player_Move.easy = true;
    }
    public void DIFmenu()
    {
        print("click");
        if (show == false)
        {
            show = true;
            print("click1");
            menus.SetActive(true);
        }
        else if (show == true)
        {
            show = false;
            print("click2");
            menus.SetActive(false);
        }
    }
}
