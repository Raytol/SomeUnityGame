using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIEscreen : MonoBehaviour
{
    float elapsedTime = 0.0f;
    public GameObject diescreen;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 3.0f)
        {
            diescreen.SetActive(true);
        }
    }
}
