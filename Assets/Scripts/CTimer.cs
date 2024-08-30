using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTimer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    Talking cTalking;
    public GameObject CTalking;

    public Text TimerTxt;

    public GameObject End1;
    public GameObject Black;

    public MonoBehaviour targetScript;

    void Start()
    {
        TimerTxt.gameObject.SetActive(false);
        Invoke("Start2", 24);
        cTalking = CTalking.GetComponent<Talking>();
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);

            }           
            else
            {
                Invoke("E11", 7);
                Invoke("E1", 10);
                cTalking.TO = true;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                targetScript.enabled = false;

                TimeLeft = 0;
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void E1()
    {
        End1.gameObject.SetActive(true);
    }

    void E11()
    {
        Black.gameObject.GetComponent<Animator>().Play("In");
    }
    void Start2()
    {
        TimerOn = true;
        TimerTxt.gameObject.SetActive(true);
    }

}
