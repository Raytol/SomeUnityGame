using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapHERE : MonoBehaviour
{
    public GameObject map;
    void Start()
    {
        if (Player_Move.easy == true)
        {
            map.SetActive(true);
        }
        else if (Player_Move.easy == false)
        {
            map.SetActive(false);
        }
    }
}
