using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRay : MonoBehaviour
{
    public float range = 30f;
    public GameObject Book;
    public GameObject Map;
    public GameObject MusicObj;
    public AudioSource VIKA;
    public GameObject Door;

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
            if(hit.collider.gameObject == Map)
            {
                Map.SetActive(false);
            }
            if(hit.collider.gameObject == MusicObj)
            {
                VIKA.Play();
            }
            if(hit.collider.gameObject == Door)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
