using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone1 : MonoBehaviour
{
    public Animator _anim;
    public GameObject TriggerZone;
    public AudioSource Door;
    public bool trigger1 = true;

    private void OnTriggerEnter(Collider TriggerZone1)
    {
        Door.Play();
        _anim.SetBool("IsOpened", false);
        trigger1 = false;
        Destroy(TriggerZone);
    }
}
