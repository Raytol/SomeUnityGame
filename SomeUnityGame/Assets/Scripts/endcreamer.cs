using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endcreamer : MonoBehaviour
{
    public GameObject credits;
    float elapsedTime = 0.0f;
    public int aa;
    private int a = 0;
    private float y = 0.1f;
    public Transform Body;

    void Update()
    {
        if (a < aa)
        {
            Body.transform.Translate(0, y, 0);
            a = a + 1;
        }
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1.0f)
        {
            credits.SetActive(true);
        }

    }
}
