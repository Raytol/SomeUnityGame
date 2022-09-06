using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider player)
    {
        SceneManager.LoadScene(0);
    }
}
