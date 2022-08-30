using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockText : MonoBehaviour
{
    private Text SuperText;

    void Start()
    {
        SuperText = GetComponent<Text>();
    }

    void Update()
    {
        SuperText.text = TimeManager.myText.text;
    }
}
