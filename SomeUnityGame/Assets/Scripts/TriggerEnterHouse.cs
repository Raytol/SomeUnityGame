using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnterHouse : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "EnterTrigger")
        {
            EnterDoor();
        }
    }

    void EnterDoor()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(2);
        }
    }
}
