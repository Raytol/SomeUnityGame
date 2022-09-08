using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextVisibleChange : MonoBehaviour
{
    public TMP_Text RunText;
    private float speed = 1f;
    void Update()
    {
        RunText.color = new Color(255,255,255,speed) ;
        speed += 0.1f;
    }
}
