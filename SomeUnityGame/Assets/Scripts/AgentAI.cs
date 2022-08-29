using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAI : MonoBehaviour
{
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
    public float distanceToPlayer;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        rotationSpeed = _navMeshAgent.angularSpeed;
        agentTransform = _navMeshAgent.transform;
        InvokeRepeating(nameof(AImove), changePosTime, changePosTime);

    }

    public void Update()
    {
        float distanceToPlayer = Vector3.Distance(Player.position, _navMeshAgent.transform.position);
        if (distanceToPlayer <= DetectionDistance || IsInView())
        {
            RotateToTarget();
            move();
        }
    }

    Vector3 RandomNavSphere (float distance)
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

    private void move()
    {
        if (IsInView())
        {
            _navMeshAgent.SetDestination(Player.position);
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
}