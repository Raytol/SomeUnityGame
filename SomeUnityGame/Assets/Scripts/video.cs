using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video : MonoBehaviour
{
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
        if (elapsedTime > 11.0f)
        {
            player.SetActive(true);
            videos.SetActive(false);
        }
    }
}
