using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public float range = 30f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Raytrue();
        }
    }

    void Raytrue()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
