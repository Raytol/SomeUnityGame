using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone2 : MonoBehaviour
{
    private AudioSource AudioCall;
    private void OnTriggerEnter(Collider triggerzone2)
    {
        AudioCall = GetComponent<AudioSource>();
        AudioCall.Play();
    }
}
