using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFaceScript : MonoBehaviour
{
    [SerializeField] private Sprite one;
    [SerializeField] private Sprite two;
    [SerializeField] private Sprite free;
    private int facecount;

    public void ChangeFace()
    {
        facecount += 1;
        if(facecount == 1)
        {
            GetComponent<Image>().sprite = two;
        }
        else if(facecount == 2)
        {
            GetComponent<Image>().sprite = free;
        }
        else
        {
            GetComponent<Image>().sprite = one;
            facecount = 0;
        }
    }
}
