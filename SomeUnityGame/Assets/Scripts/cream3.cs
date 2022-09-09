using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cream3 : MonoBehaviour
{
    public GameObject player;
    public GameObject kak;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider player)
    {
        kak.SetActive(true);
    }
}
