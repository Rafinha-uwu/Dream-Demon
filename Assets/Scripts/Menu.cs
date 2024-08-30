using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    CTimer cTimer;
    public GameObject Timer;


    public bool MenuOpen = false;

    public Transform Base1;

    public MonoBehaviour targetScript;


    // Start is called before the first frame update
    void Start()
    {

        cTimer = Timer.GetComponent<CTimer>();

        Base1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Keybord to open menu
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (MenuOpen == false)
            {
                Invoke("Open", 0);
            }
            else
            {
                Invoke("Resume", 0);
            }
        }

    }
    public void Open()
    {
        this.GetComponent<AudioSource>().Play();
        cTimer.TimerOn = false;
        targetScript.enabled = false;
        MenuOpen = true;
        Base1.gameObject.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void Resume()
    {
        this.GetComponent<AudioSource>().Play();
        cTimer.TimerOn = true;
        targetScript.enabled = true;
        MenuOpen = false;
        Base1.gameObject.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void Restart()
    {
        this.GetComponent<AudioSource>().Play();
        MenuOpen = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        this.GetComponent<AudioSource>().Play();
        MenuOpen = false;
        print("Aplicação terminou!");
        Application.Quit();
    }
}
