using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallclose : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
    private bool a = true;
    void Start()
    {
        wall.SetActive(true);
        a = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider player)
    {
        if (a == true)
        {
            wall.SetActive(true); 
            a = false;
        }
    }
}
