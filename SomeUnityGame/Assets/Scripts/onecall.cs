using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onecall : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public GameObject player;
    public bool playonetime = true;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider player)
    {
        if (playonetime == true)
        {
            m_MyAudioSource.Play();
            playonetime = false;
        }
    }
}
