using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject monster;
    public GameObject player;
    private void Start()
    {
        monster.SetActive(false);
    }
    private void OnTriggerEnter(Collider player)
    {
        monster.SetActive(true);
    }
}
