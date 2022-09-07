using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSystem : MonoBehaviour
{
    public GameObject au;
    public GameObject player;
    AudioSource m_MyAudioSource;
    private void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider player)
    {
        m_MyAudioSource.Play();
        au.SetActive(false);
    }
}
