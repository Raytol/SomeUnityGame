using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamer2 : MonoBehaviour
{
    private bool A = true;
    public GameObject player;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider player)
    {
        if (A == true)
        {
            m_MyAudioSource.Play();
            A = false;
        }
    }
}
