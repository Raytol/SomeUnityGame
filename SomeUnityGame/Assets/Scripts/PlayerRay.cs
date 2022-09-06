using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerRay : MonoBehaviour
{
    public GameObject scrolls1;
    public GameObject scrolls2;
    public GameObject scrolls3;
    public GameObject scrolls4;
    public GameObject scrolls5;
    public GameObject scrolls6;
    public GameObject scrolls7;
    public GameObject scrolls8;
    public GameObject scrolls9;
    public GameObject scrolls10;

    public GameObject scrolls;
    public float range = 30f;
    public GameObject scroll;
    public GameObject Book;
    public GameObject Map;
    public GameObject MusicObj;
    public AudioSource VIKA;
    public GameObject Door;
    public TriggerZone1 trigger;
    public GameObject Bed;
    public Text ProposedText;

    void Update()
    {
        RaycastHit _hit2;
        if (Physics.Raycast(transform.position, transform.forward, out _hit2, range))
        {
            if (_hit2.collider.gameObject == Bed)
            {
                ProposedText.text = "Сосать будешь??";
            }
            else
            {
                ProposedText.text = "";
            }
        }

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
            if (hit.collider.gameObject == Book)
            {
                Win.book = true;
                Book.SetActive(false);
            }
            else if (hit.collider.name == "EnterCollider")
            {
                SceneManager.LoadScene(2);
            }
            else if (hit.collider.gameObject == Map)
            {
                Win.mapa = true;
                Map.SetActive(false);
            }
            else if (hit.collider.gameObject == MusicObj)
            {
                VIKA.Play();
            }
            else if (hit.collider.gameObject == Door && trigger.trigger1 == true)
            {
                hit.transform.GetComponent<Door>().Open();
            }
            else if (hit.collider.gameObject == scroll)
            {
                Win.scrolla = Win.scrolla + 1;
                scroll.SetActive(false);
                scrolls.SetActive(true);
            }
            else if (hit.collider.gameObject == scrolls1)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls1.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls2)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls2.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls3)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls3.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls4)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls4.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls5)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls5.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls6)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls6.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls7)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls7.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls8)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls8.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls9)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls9.SetActive(false);
            }
            else if (hit.collider.gameObject == scrolls10)
            {
                Win.scrolla = Win.scrolla + 1;
                scrolls10.SetActive(false);
            }
        }
    }
}
