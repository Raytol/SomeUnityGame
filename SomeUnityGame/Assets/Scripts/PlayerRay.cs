using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRay : MonoBehaviour
{
    public float range = 30f;
    public GameObject Book;
    
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
            if(hit.collider.gameObject == Book)
            {
                Book.SetActive(false);
            }
            if(hit.collider.name == "EnterCollider")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
