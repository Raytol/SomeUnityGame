using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnterHouse : MonoBehaviour
{
    public GameObject colider;
    public GameObject Player;

    private void OnTriggerEnter(Collider col)
    {
        //f(col.name == "EnterTrigger" && Input.GetButtonDown())
        //{
        //    SceneManager.LoadScene(2);
        //}
    }
}
