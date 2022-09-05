using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallclose : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
    public GameObject script;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider player)
    {
        wall.SetActive(true);
        Destroy(script);
    }
}
