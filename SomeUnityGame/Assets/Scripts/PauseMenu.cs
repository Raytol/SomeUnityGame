using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject MenuPaused;
    public GameObject CenterDot;
    public Player_Mouse_Move playermouse;
    public Player_Move playermove;
    [SerializeField] KeyCode keymenupaused;
    bool isMenuPaused = false;

    private void Start()
    {
        MenuPaused.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }

    void ActiveMenu()
    {
        if (Input.GetKeyDown(keymenupaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            Time.timeScale = 0;
            MenuPaused.SetActive(true);
            CenterDot.SetActive(false);
            playermouse.enabled = false;
            playermove.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
        else
        {
            Time.timeScale = 1;
            MenuPaused.SetActive(false);
            CenterDot.SetActive(true);
            playermouse.enabled = true;
            playermove.enabled = true;
            Cursor.visible = false;
            
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
