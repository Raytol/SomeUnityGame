using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadscene : MonoBehaviour
{
    public bool reload = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reload == true)
        {
            print('1');
            SceneManager.LoadScene(0);
            reload = false;
        }
;
    }
}
