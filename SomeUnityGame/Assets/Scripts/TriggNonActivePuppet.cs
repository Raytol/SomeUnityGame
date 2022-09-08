using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggNonActivePuppet : MonoBehaviour
{
    public GameObject NonActivePuppet;
    private Transform PuppetTransform;
    public int rotationSpeed = 45;
    public Transform Player;

    private void OnTriggerEnter(Collider PassiveCol)
    {
        PuppetTransform = NonActivePuppet.GetComponent<Transform>();
        NonActivePuppet.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        NonActivePuppet.SetActive(false);
    }

    private void Update()
    {
        if (NonActivePuppet.activeSelf)
        {
            RotateToTarget();
            RaycastHit hit;
            if (Physics.Raycast(PuppetTransform.transform.position, Player.position - PuppetTransform.position, out hit, 15))
            {
                NonActivePuppet.SetActive(false);
            }
        }
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
