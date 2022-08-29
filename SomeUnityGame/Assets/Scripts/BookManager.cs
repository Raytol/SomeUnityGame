using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookManager : MonoBehaviour
{
    public GameObject Book;
    public GameObject Menu;
    public GameObject BookMenu;

    bool boolean = true;

    private void Start()
    {
        BookMenu.SetActive(false);
    }

    void Update()
    {
        if (!Book.activeInHierarchy && !Menu.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                BookMenu.SetActive(boolean);
                boolean = !boolean;
            }
        }
    }
}
