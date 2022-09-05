using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour
{
    public GameObject image;
    public Sprite aa;
    private Sprite ab;
    public Sprite a0;
    public Sprite a1;
    public Sprite a2;
    public Sprite a3;
    public Sprite a4;
    public Sprite a5;
    public Sprite a6;
    public Sprite a7;
    void Start()
    {
        ab = a0;
        aa = GetComponent<Sprite>() as Sprite;
        aa = ab;
        

    }

    // Update is called once per frame
    void Update()
    {
        aa = ab;

        if (ab == a0)
        {
            ab = a1;
        }
        else if (ab == a1)
        {
            ab = a2;
        }
        else if (ab == a2)
        {
            ab = a3;
        }
        else if (ab == a3)
        {
            ab = a4;
        }
        else if (ab == a4)
        {
            ab = a5;
        }
        else if (ab == a5)
        {
            ab = a6;
        }
        else if (ab == a6)
        {
            ab = a7;
        }
        else if (ab == a7)
        {
            ab = a0;
        }
    }
}
