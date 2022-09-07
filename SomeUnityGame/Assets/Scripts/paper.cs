using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : MonoBehaviour
{
    public static bool sound = false;
    AudioSource m_MyAudioSource;
    void Start()
    {
       m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sound == true)
        {
            m_MyAudioSource.Play();
            sound = false;
        }
    }
}
