using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnterHouse : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "EnterTrigger" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(2);
        }
    }
}
