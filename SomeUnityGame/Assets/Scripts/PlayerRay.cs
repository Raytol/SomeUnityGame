using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerRay : MonoBehaviour
{
    public static bool call2;
    public GameObject text1;
    public GameObject text2;
    public GameObject text2COLLIDER;

    private bool a1;
    private bool a2;
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

    public GameObject kscrolls1;
    public GameObject kscrolls2;
    public GameObject kscrolls3;
    public GameObject kscrolls4;
    public GameObject kscrolls5;
    public GameObject kscrolls6;
    public GameObject kscrolls7;
    public GameObject kscrolls8;
    public GameObject kscrolls9;
    public GameObject kscrolls10;

    public AudioSource ScrollSound;

    public GameObject scrolls;
    public float range = 30f;
    public GameObject scroll;
    public GameObject Book;
    public GameObject Map;
    public GameObject MusicObj;
    private AudioSource VIKA;
    public GameObject Door;
    public TriggerZone1 trigger;
    public GameObject Bed;
    public AudioSource DoorSound;
    private bool IsAudioPlay = false;
    public GameObject Scream1;
    public GameObject Prefab;
    public GameObject NearPhone;
    public GameObject TriggerSoundCollider;
    public AudioSource RealPhoneSound1;
    public AudioSource GoodKi;
    public PauseMenu MapPause;
    private bool trigger2 = false;
    private bool IsPhoneActive = false;
    public GameObject godki;
    //public Text ProposedText;

    private void Start()
    {
        text2COLLIDER.SetActive(false);
        text2.SetActive(false);
        call2 = false;
        text1.SetActive(false);
        a1 = false;
        a2 = false;
        scrolls1.SetActive(true);
        scrolls2.SetActive(true);
        scrolls3.SetActive(true);
        scrolls4.SetActive(true);
        scrolls5.SetActive(true);
        scrolls6.SetActive(true);
        scrolls7.SetActive(true);
        scrolls8.SetActive(true);
        scrolls9.SetActive(true);
        scrolls10.SetActive(true);
        kscrolls1.SetActive(false);
        kscrolls2.SetActive(false);
        kscrolls3.SetActive(false);
        kscrolls4.SetActive(false);
        kscrolls5.SetActive(false);
        kscrolls6.SetActive(false);
        kscrolls7.SetActive(false);
        kscrolls8.SetActive(false);
        kscrolls9.SetActive(false);
        kscrolls10.SetActive(false);
        scrolls.SetActive(false);
        scroll.SetActive(true);
        Book.SetActive(true);
        godki.SetActive(false);
    }

    void Update()
    {
        //RaycastHit _hit2;
        //if (Physics.Raycast(transform.position, transform.forward, out _hit2, range))
        //{
        //    if (_hit2.collider.gameObject == Bed)
        //   {
        //        ProposedText.text = "?????? ????????";
        //    }
        //    else
        //    {
        //        ProposedText.text = "";
        //    }
        //}
        if (a1 == true && a2 == true)
        {
            DoorSound.Play();
            trigger.trigger1 = true;
            a1 = false;
            a2 = false;
            text2COLLIDER.SetActive(true);
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
                a2 = true;
                if (Player_Move.easy == false)
                {
                    a1 = true;
                }
                paper.sound = true;
                Win.book = true;
                Book.SetActive(false);
                Win.mapa = true;
            }
            else if (hit.collider.name == "EnterCollider")
            {
                SceneManager.LoadScene(2);
            }
            else if (hit.collider.gameObject == Map)
            {
                a1 = true;
                paper.sound = true;
                Map.SetActive(false);
                MapPause.isMapClaimed = true;
            }
            else if (hit.collider.gameObject == MusicObj)
            {
                IsAudioPlay = !IsAudioPlay;
                VIKA = MusicObj.GetComponent<AudioSource>();
                if (IsAudioPlay)
                {
                    VIKA.Play();
                }
                else
                {
                    VIKA.Stop();
                }
            }
            else if(hit.collider.gameObject == Scream1)
            {
                Vector3 spawnPos = transform.position + new Vector3(5, 0, 5);
                Prefab.SetActive(true);
                Instantiate(Prefab, spawnPos, Quaternion.identity);
            }
            else if (hit.collider.gameObject == Door && trigger.trigger1 == true && trigger2)
            {
                hit.transform.GetComponent<Door>().Open();
            }
            else if (hit.collider.gameObject == scroll)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scroll.SetActive(false);
                scrolls.SetActive(true);
            }
            else if (hit.collider.gameObject == scrolls1)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls1.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls1.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls2)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls2.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls2.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls3)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls3.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls3.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls4)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls4.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls4.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls5)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls5.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls5.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls6)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls6.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls6.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls7)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls7.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls7.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls8)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls8.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls8.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls9)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls9.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls9.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if (hit.collider.gameObject == scrolls10)
            {
                paper.sound = true;
                Win.scrolla = Win.scrolla + 1;
                scrolls10.SetActive(false);
                if (Player_Move.easy == true)
                {
                    kscrolls10.SetActive(true);
                    ScrollSound.Play();
                }
            }
            else if(hit.collider.gameObject == NearPhone)
            {
                if (!IsPhoneActive)
                {
                    text1.SetActive(true);
                    IsPhoneActive = !IsPhoneActive;
                    trigger2 = true;
                    Destroy(TriggerSoundCollider);
                    RealPhoneSound1.Play();

                }
                else
                {
                    if (call2 == true)
                    {
                        text2.SetActive(true);
                        RealPhoneSound1.Play();
                        trigger2 = true;
                        call2 = false;
                        Destroy(text2COLLIDER);
                    }
                    else
                    {
                        godki.SetActive(true);
                        RealPhoneSound1.Stop();
                    }
                }
            }
        }
    }
}
