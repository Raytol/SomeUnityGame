using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musick : MonoBehaviour
{
    private int clipnub;

    public AudioClip otherClip1;
    public AudioClip otherClip2;
    public AudioClip otherClip3;

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;  
    }

    // Update is called once per frame
    void Update()
    {

        if (!audioSource.isPlaying)
        {
            clipnub = Random.Range(1, 3);
            clips();
            audioSource.Play();
        }
    }
    public void clips()
    {
        if (clipnub == 1)
        {
            audioSource.clip = otherClip1;
        }
        else if (clipnub == 2)
        {
            audioSource.clip = otherClip2;
        }
        else if (clipnub == 3)
        {
            audioSource.clip = otherClip3;
        }
    }

}
