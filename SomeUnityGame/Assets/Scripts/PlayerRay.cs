using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerRay : MonoBehaviour
{
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
                Book.SetActive(false);
            }
            else if (hit.collider.name == "EnterCollider")
            {
                SceneManager.LoadScene(2);
            }
            else if (hit.collider.gameObject == Map)
            {
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
                print('1');
                scroll.SetActive(false);
            }
        }
    }
}
