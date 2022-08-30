using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int second, minute1, minute2, hour1, hour2;
    private float gameTime;
    private Text myText;

    void Start()
    {
        myText = GetComponent<Text>();    
    }
    void Update()
    {
        myText.text = hour1 + hour2 + ":" + minute1 + minute2;
        gameTime += 1 * Time.deltaTime;
        if (gameTime > 1)
        {
            second += 1;
            gameTime = 0;
        }

        if (second == 5)
        {
            minute2 += 5;
            second = 0;
            if (minute2 == 10)
            {
                minute1 += 1;
                minute2 = 0;
                if (minute1 == 6)
                {
                    hour1 += 1;
                    minute1 = 0;
                }
            }
        }
    }
}
