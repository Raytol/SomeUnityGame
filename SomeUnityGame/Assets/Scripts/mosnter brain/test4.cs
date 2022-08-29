using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test4 : MonoBehaviour
{

    public float M;

    private NavMeshAgent _navMeshAgent;
    private float changePosTime = 2f;
    private float MoveDistance = 30f;
    private float rotationSpeed;
    private Transform agentTransform;
    public Vector3 LastPos;

    [Range(0, 360)] public float ViewAngle = 90f;
    public float ViewDistance = 15f;
    public float DetectionDistance = 3f;
    public Transform AgentBobby;
    public Transform Player;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        rotationSpeed = _navMeshAgent.angularSpeed;
        agentTransform = _navMeshAgent.transform;
        InvokeRepeating(nameof(AImove), changePosTime, changePosTime);
        M = 1f;
    }


    void Update()
    {
      
        float distanceToPlayer = Vector3.Distance(Player.transform.position, _navMeshAgent.transform.position);
        
        switch (M)
        {
            case 1f:
                print("case 1");
                if (distanceToPlayer <= DetectionDistance || IsInView())
                {
                    M = 2f;
                }
                break;

            case 2f:
                print("case 2");
                if (distanceToPlayer <= DetectionDistance || IsInView())
                {
                    LastPos = Player.position;
                    RotateToTarget();
                    move();


                    if (distanceToPlayer <= 2f)
                    {
                        {
                            M = 4f;
                        }
                    }
                }
                else
                {
                  M = 3f;
                }
                break;

            case 3f:
                print("case 3");
                float distanceToLastPos = Vector3.Distance(LastPos, _navMeshAgent.transform.position);
                _navMeshAgent.SetDestination(LastPos);
                if (distanceToLastPos <= 5f)
                {
                    M = 1f;
                }
                break;

            case 4f:
                print("GAME END");
                M = 1f;
                break;
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

    private void RotateToTarget()
    {
        Vector3 lookVector = Player.position - agentTransform.position;
        lookVector.y = 0;
        if (lookVector == Vector3.zero) return;
        agentTransform.rotation = Quaternion.RotateTowards
            (
            agentTransform.rotation,
            Quaternion.LookRotation(lookVector, Vector3.up),
            rotationSpeed * Time.deltaTime
            );
    }
    private void move()
    {
        if (IsInView())
        {
            _navMeshAgent.SetDestination(Player.position);
        }
    }
}