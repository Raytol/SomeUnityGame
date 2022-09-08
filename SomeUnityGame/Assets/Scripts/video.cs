using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video : MonoBehaviour
{
    private bool kak =true;
    private float kek = 0;
    public GameObject names;
    float elapsedTime = 0.0f;
    public GameObject videos;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 13.0f)
        {
            if (kak == true)
            {
                names.SetActive(true);
            }
            if (elapsedTime > 16.0f)
            {
                videotwo.a = 2;
            }
            else
            {
                videotwo.a = 1;
            }
            kek = kek + 0.05f;
            player.SetActive(true);
            videos.SetActive(false);
        }
        else if (elapsedTime > 19.0f)
        {
            kak = false;
            names.SetActive(false);
        }
    }
}
