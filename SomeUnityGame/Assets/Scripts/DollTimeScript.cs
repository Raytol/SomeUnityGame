using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DollTimeScript : MonoBehaviour
{
    private float Times;
    private int Sec;

    public GameObject doll1;
    public GameObject doll2;
    public GameObject doll3;

    private int randnum;

    private void Update()
    {
        Times += 1 * Time.deltaTime;
        if (Times > 1)
        {
            Sec += 1;
            Times = 0;
        }

        if (Sec == 10)
        {
            Sec = 0;
            Rand();
            if (randnum == 1)
            {
                doll1.SetActive(true);
                doll2.SetActive(false);
                doll3.SetActive(false);
            }
            else if (randnum == 2)
            {
                doll1.SetActive(false);
                doll2.SetActive(true);
                doll3.SetActive(false);
            }
            else if (randnum == 3)
            {
                doll1.SetActive(false);
                doll2.SetActive(false);
                doll3.SetActive(true);
            }
        }
    }

    void Rand()
    {
        randnum = Random.Range(1, 3);
    }
}
