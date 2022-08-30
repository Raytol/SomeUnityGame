using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
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
    public int run_timeP;
    public int run_time;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        run_time = run_timeP;
        player = GetComponent<CharacterController>();
        m_MyAudioSource.Stop();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            //if (Input.GetKey(KeyCode.Space))
            //{
            //    move_Direction.y += jump;
            //}
            if (Input.GetKey(KeyCode.LeftControl))
            {
                player.height = 1.0f;
                speed_Current = speed_Seat;
            }
            else
            {
                player.height = 2f;
            }
        }
        move_Direction.y -= gravity;
        if (run_gone == false && Input.GetKey(KeyCode.LeftShift) && run_time <= run_timeP && run_time > 0)
        {
            m_MyAudioSource.Stop();
            run_time = run_time - 2;
            speed_Current = speed_Run;
            if (run_time == 0)
            {
                audioW = true;
                run_gone = true;
            }

        }
        else
        {
            speed_Current = speed_Move;
            if (run_time >= 0 && run_time < run_timeP && run_gone == true)
            {
                if (audioW == true)
                {
                    audioW = false;
                    m_MyAudioSource.Play();
                }

                print("3");
                run_time = run_time + 1;
                if (run_time == run_timeP)
                {
                    m_MyAudioSource.Stop();
                    run_gone = false;
                }
            }
        }
        player.Move(move_Direction * speed_Current * Time.deltaTime);
    }
}
