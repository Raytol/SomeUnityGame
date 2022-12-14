using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour
{
    public static bool easy = true;

    public GameObject runa;
    public GameObject movea;

    public Animator animator;
    public float Y = -1f;
    public float Z = 0f;
    public bool Stay = false;

    private bool crunched;

    AudioSource m_MyAudioSource;

    public float speed_Move;
    public float speed_Run;
    public float speed_Seat;
    public float speed_Current;
    public float jump;
    public float gravity;
    float x_Move;
    float z_Move;
    CharacterController player;
    Vector3 move_Direction;
    public bool run_gone = false;
    public bool audioW = false;
    public float run_timeP;
    public float run_time;
    public Camera Cam;
    public GameObject Seat;
    public GameObject Normal;
    public Slider Bar;  


    void Start()
    {

        animator = GetComponent<Animator>();
        m_MyAudioSource = GetComponent<AudioSource>();
        run_time = run_timeP;
        player = GetComponent<CharacterController>();
        m_MyAudioSource.Stop();
    }

    void Update()
    {
        Bar.value = run_time;
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Stay = false;
        }
        else
        {
            animaI();
            Stay = true;
        }
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKey(KeyCode.LeftControl))
            {
            }
            else
            { 
                crunched = false;
                animator.SetBool("crouche", false);
                player.height = 2f;
                Cam.transform.position = Normal.transform.position;
            }
        }
        move_Direction.y -= gravity;
        if (run_gone == false && crunched == false && Input.GetKey(KeyCode.LeftShift) && run_time <= run_timeP && run_time > 0)
        {
            runa.SetActive(true);
            movea.SetActive(false);
            animaR();
            m_MyAudioSource.Stop();
            run_time = run_time - 4;
            speed_Current = speed_Run;
            if (run_time == 0)
            {
                audioW = true;
                run_gone = true;
            }

        }
        else
        {
            if (Stay == false)
            {
                runa.SetActive(false);
                movea.SetActive(true);
                animaW();
            }
            else
            {
                runa.SetActive(false);
                movea.SetActive(false);
            }
            speed_Current = speed_Move;
            if (run_gone == true)
            {
                if (audioW == true)
                {
                    audioW = false;
                    m_MyAudioSource.Play();
                }

                run_time = run_time + 1;
                if (run_time == run_timeP)
                {

                    m_MyAudioSource.Stop();
                    run_gone = false;
                }
                print("slow");
            }
            if (easy == true && run_time < run_timeP && run_gone == false)
            {
                print("ez");
                run_time = run_time + 2;
            }
            if (easy == false && run_time < run_timeP && run_gone == false && Stay == true)
            {
                print("hard");
                run_time = run_time + 2;
            }
        }
        player.Move(move_Direction * speed_Current * Time.deltaTime);
    }
    private void animaI()
    {
        if (crunched == false)
        {
            if (Y > -1f)
            {
                Y = Y - 0.1f;
            }
            animator.SetFloat("Y", Y);
        }
        else if (crunched == true)
        {
            if (Z > 0f)
            {
                Z = Z - 0.1f;
            }
            animator.SetFloat("Z", Z);
        }
    }
    private void animaW()
    {
        if (crunched == false)
        {
            if (Y > 0f)
            {
                Y = 0f;
            }
            else if (Y < 0f)
            {
                Y = 0f;
            }
            animator.SetFloat("Y", Y);
        }
        else if (crunched == true)
        {
            if (Z < 1f)
            {
                Z = Z + 0.1f;
            }
            animator.SetFloat("Z", Z);
        }
    }
    private void animaR()
    {
        if (Y < 1f)
        {
            Y = Y + 0.1f;
        }
        animator.SetFloat("Y", Y);

    }
}
