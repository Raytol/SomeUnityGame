using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call3 : MonoBehaviour
{
    private bool yrs;
    private AudioSource AudioCall;
    public GameObject player;
    public GameObject text3;
    void Start()
    {
        yrs = true;
        text3.SetActive(false);
        AudioCall = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider player)
    {
        if (yrs == true)
        {
            AudioCall.Play();
            PlayerRay.call2 = true;
            yrs = false;
            text3.SetActive(true);
        }
    }
}
