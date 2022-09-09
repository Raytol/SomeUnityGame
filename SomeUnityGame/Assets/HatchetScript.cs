using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatchetScript : MonoBehaviour
{
    public GameObject Hatchet;
    private AudioSource HatchetSound;

    private void OnTriggerEnter(Collider col5)
    {
        HatchetSound = GetComponent<AudioSource>();
        Hatchet.SetActive(true);
        HatchetSound.Play();
    }
}
