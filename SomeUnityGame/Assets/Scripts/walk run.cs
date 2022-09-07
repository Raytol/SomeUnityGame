using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkrun : MonoBehaviour
{
    public bool walk = false;
    public bool run = false;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (run == true)
        {
            m_MyAudioSource.Play();
        }
        else if (walk == true)
        {
            m_MyAudioSource.Play();
        }
        else
        {
            m_MyAudioSource.Stop();
        }
    }
}
