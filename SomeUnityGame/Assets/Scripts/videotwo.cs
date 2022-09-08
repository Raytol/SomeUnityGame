using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videotwo : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public Animator animator;
    public static int a = 0;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (a == 1)
        {
            m_MyAudioSource.Play();
            animator.SetBool("start", true);
        }
        else if (a == 2)
        {
            animator.SetBool("end", true);
        }
    }
}
