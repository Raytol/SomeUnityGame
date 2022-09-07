using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int second1, second2,  minute1, minute2, hour1, hour2;
    private float gameTime;
    public static Text myText;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        myText.text = hour1 + hour2 + ":" + minute1 + minute2 + ":" + second1 + second2;
        gameTime += 1 * Time.deltaTime;
        if (gameTime > 1)
        {
            second2 += 1;
            gameTime = 0;
        }
   
        if (second2 == 10)
        {
            second1 += 1;
            second2 = 0;
            if (second1 == 6)
            {
                second1 = 0;
                minute2 += 1;
                if (minute2 == 10)
                {
                    minute1 += 1;
                    minute2 = 0;
                    if (minute1 == 6)
                    {
                        hour2 += 1;
                        minute1 = 0;
                        if (hour2 == 10)
                        {
                            hour1 += 1;
                            hour2 = 0;
                        }
                    }
                }
            }
        }
    }
}
