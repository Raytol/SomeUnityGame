using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test4 : MonoBehaviour
{
    Animator animator;
    float X = 0f;
    float Y = -1f;

    public float M;
    AudioSource m_MyAudioSource;

    private NavMeshAgent _navMeshAgent;
    private float changePosTime = 2f;
    private float MoveDistance = 30f;
    private float rotationSpeed;
    private Transform agentTransform;
    public Vector3 LastPos;

    [Range(0, 360)] public float ViewAngle = 90f;
    private float ViewDistance = 15f;
    private float DetectionDistance = 3f;
    public Transform AgentBobby;
    public Transform Player;
    public GameObject DIe;

    void Start()
    {
        if (Player_Move.easy == true)
        {
            ViewDistance = 40f;
            DetectionDistance = 40f;
            m_MyAudioSource.maxDistance = 60f;
        }
        else if (Player_Move.easy == false)
        {
            ViewDistance = 50f;
            DetectionDistance = 50f;
            m_MyAudioSource.maxDistance = 40f;
        }
        m_MyAudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        rotationSpeed = _navMeshAgent.angularSpeed;
        agentTransform = _navMeshAgent.transform;
        InvokeRepeating(nameof(AImove), changePosTime, changePosTime);
        M = 1f;
        DIe.SetActive(false);
    }
    void Update()
    {

        float distanceToPlayer = Vector3.Distance(Player.transform.position, _navMeshAgent.transform.position);

        switch (M)
        {
            case 1f:
                //print("case 1");
                animator.SetFloat("x", X);
                animator.SetFloat("y", Y);
                animaW();
                if (distanceToPlayer <= DetectionDistance || IsInView())
                {
                    M = 2f;
                }
                break;

            case 2f:
                //print("case 2");
                animator.SetFloat("x", X);
                animator.SetFloat("y", Y);
                animaR();
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
                //print("case 3");
                animator.SetFloat("y", Y);
                animaW();
                if (distanceToPlayer <= DetectionDistance || IsInView())
                {
                    M = 2f;
                }
                float distanceToLastPos = Vector3.Distance(LastPos, _navMeshAgent.transform.position);
                _navMeshAgent.SetDestination(LastPos);
                if (distanceToLastPos <= 5f)
                {
                    M = 1f;
                }
                break;

            case 4f:
                //print("GAME END");
                DIe.SetActive(true);
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

    public void animaR()
    {
        if (Y <= 1)
        {
            Y = Y + 0.01f;
        }
        else if (Y >= 1f)
        {
            _navMeshAgent.speed = 11f;
            Y = Y - 0.01f;
        }
        if (_navMeshAgent.speed <= 11f)
        {
            _navMeshAgent.speed = 11f;
        }
        else if (_navMeshAgent.speed >= 11f)
        {
            _navMeshAgent.speed = 11f;
        }
    }
    public void animaW()
    {
        if (Y <= 0)
        {
            _navMeshAgent.speed = 11f;
            Y = Y + 0.01f;
        }
        else if (Y >= 0f)
        {
            _navMeshAgent.speed = 11f;
            Y = Y - 0.01f;
        }
        if (_navMeshAgent.speed <= 5.5f)
        {
            _navMeshAgent.speed = 5.5f;
        }
        else if (_navMeshAgent.speed >=5.5f)
        {
            _navMeshAgent.speed = 11f;
        }
    }
    public void animaS()
    {
        if (Y >= -1)
        {
            _navMeshAgent.speed = 11f;
            Y = Y - 0.03f;
        }
        if (_navMeshAgent.speed <= 0f)
        {
            _navMeshAgent.speed = 0f;
        }
        else if (_navMeshAgent.speed >= 0f)
        {
            _navMeshAgent.speed = 11f;
        }
    }
}
