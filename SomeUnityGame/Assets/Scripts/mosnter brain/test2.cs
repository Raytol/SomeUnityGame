using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
   

    public static bool Ms;
    public static float M;

    void Start()
    {
        M = 1f;
        Ms = true;  
    }


    void Update()
    {
        if (Ms == true)
        {

            switch (M)
            {
                case 1f:
                    Ms = false;
                    test1.Ma = true;

                    break;
                case 2f:
                    Ms = false;

                    break;
                case 3f:
                    Ms = false;

                    break;
                case 4f:
                    Ms = false;

                    break;
            }
        }
    }
}