using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamer1 : MonoBehaviour
{
    public GameObject Doll;
    public GameObject DollB;
    private bool Seev = false;
    private bool Seeb = false;
    private bool See = false;
    public Transform Player;
    public Transform AgentBobby;
    public float ViewDistance = 15f;
    [Range(0, 360)] public float ViewAngle = 360f;

    void Start()
    {

    }
    void Update()
    {
        if (Win.mapa == false)
        {
            if (IsInView())
            {
                if (Seeb == true)
                {
                    Seev = true;
                }
                See = true;
            }
            if (See == true && IsInView() == false)
            {
                Seeb = true;
                Doll.SetActive(false);
            }
            if (Seev == true && IsInView() == false)
            {
                DollB.SetActive(true);
            }
        }
        else
        {
            DollB.SetActive(false);
            Doll.SetActive(false);
        }

    }
    private bool IsInView()
    {
        float realAngle = Vector3.Angle(AgentBobby.forward, Player.position - AgentBobby.position);
        RaycastHit hit;
        if (Physics.Raycast(AgentBobby.transform.position, Player.position - AgentBobby.position, out hit, ViewDistance))
        {
            if (realAngle < ViewAngle / 2f && Vector3.Distance(AgentBobby.position, Player.position) <= ViewDistance && hit.transform == Player.transform)
            {
                return true;
            }
        }
        return false;
    }
}
