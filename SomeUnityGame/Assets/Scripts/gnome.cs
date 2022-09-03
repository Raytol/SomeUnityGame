using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gnome : MonoBehaviour
{
    public float t = 0;
    public float Freq = 2;
    public float Offset = 0;
    public float Amp = 0.25f;
    public Vector3 StartPos;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self);
        t = t + Time.deltaTime;
        Offset = Amp * Mathf.Sin(t * Freq);
        transform.position = StartPos + new Vector3(0,Offset,0);
    }
}
