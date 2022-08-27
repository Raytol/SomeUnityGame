using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class test1 : MonoBehaviour
{

    public static bool Ma;


    private NavMeshAgent _navMeshAgent;
    private float changePosTime = 2f;
    private float MoveDistance = 30f;
    private float rotationSpeed;
    private Transform agentTransform;

    [Range(0, 360)] public float ViewAngle = 90f;
    public float ViewDistance = 15f;
    public float DetectionDistance = 3f;
    public Transform AgentBobby;
    public Transform Player;


    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        InvokeRepeating(nameof(AImove), changePosTime, changePosTime);
        agentTransform = _navMeshAgent.transform;
        Ma = false;
    }


    private void update()
    {
        if (Ma == true)
        {
            float distanceToPlayer = Vector3.Distance(Player.transform.position, _navMeshAgent.transform.position);
            if (distanceToPlayer <= DetectionDistance || IsInView())
            {
                test2.Ms = true;
                test2.M = 3f;
                Ma = false;

            }
        }
    }


    Vector3 RandomNavSphere(float distance)
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;
        randomDirection += transform.position;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, distance, -1);
        return navHit.position;
    }


    private void AImove()
    {
        _navMeshAgent.SetDestination(RandomNavSphere(MoveDistance));
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