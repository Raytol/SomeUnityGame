using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggNonActivePuppet : MonoBehaviour
{
    public GameObject NonActivePuppet;
    private Transform PuppetTransform;
    public int rotationSpeed = 30;
    public Transform Player;

    private void OnTriggerEnter(Collider PassiveCol)
    {
        PuppetTransform = NonActivePuppet.GetComponent<Transform>();
        NonActivePuppet.SetActive(true);
        RotateToTarget();

    }

    private void RotateToTarget()
    {
        Vector3 lookVector = Player.position - PuppetTransform.position;
        lookVector.y = 0;
        if (lookVector == Vector3.zero) return;
        PuppetTransform.rotation = Quaternion.RotateTowards
            (
            PuppetTransform.rotation,
            Quaternion.LookRotation(lookVector, Vector3.up),
            rotationSpeed * Time.deltaTime
            );
    }
}
