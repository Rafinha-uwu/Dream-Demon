using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
    //Sounds

    public AudioSource Barsup;
    public AudioSource Chests;
    public AudioSource Correct;
    public AudioSource Incorrect;
    public AudioSource Stonedoor;
    public AudioSource Keyswitch;
    public AudioSource Lswitch;
    public AudioSource Sread;



    //End

    Talking cTalking;
    public GameObject CTalking;

    public GameObject End3;
    public GameObject White;

    //grab
    public bool key1 = false;
    public bool key2 = false;

    Transform Hited;

    Manager cManager;
    public GameObject CManager;

    public Transform Hand;
    public Transform World;


    //chests

    CTimer cTimer;
    public GameObject Timer;

    Transform Opened;

    string Input;

    public Light light2;
    public Light light3;

    public InputField num1;
    bool prim = false;
    bool Once1 = true;

    bool sec = false;
    bool Once2 = true;

    bool Fake1 = true;

    bool Yup = true;
    bool Nop = true;

    bool third = false;
    bool Oncedoor = true;
    public GameObject DOOR;


    public Transform BaseInput;

    public MonoBehaviour targetScript;

    //Suport

    public GameObject Bars;
    public GameObject Lever;

    public GameObject Lever2;

    public GameObject Key2;


    public GameObject Wall;

    Morse cMorse;
    public GameObject CMorse;

    //Read

    Transform Red;

    Lantern cLantern;
    public GameObject CLantern;

    public bool stay = true;
    public bool inside = false;

    //SK

    public Animator ExitGate;
    public bool sk1 = false;
    public bool sk2 = false;
    public bool sk3 = false;

    public float op = 0;

    public GameObject k1;
    public GameObject k2;
    public GameObject k3;

    public Light Finallight;
    public bool fl = false;


    public void Start()
    {
        cMorse = CMorse.GetComponent<Morse>();
        cTimer = Timer.GetComponent<CTimer>();
        cLantern = CLantern.GetComponent<Lantern>();
        cManager = CManager.GetComponent<Manager>();
        cTalking = CTalking.GetComponent<Talking>();

        Lever.gameObject.SetActive(false);
    }

    public void Update()
    {


        RaycastHit hit;
        RaycastHit open;
        RaycastHit key;
        RaycastHit read;

        //grab 
        if (Mouse.current.rightButton.wasPressedThisFrame && cManager.grabing == true)
        {

            Hited.SetParent(World);
            Hited.GetComponent<Rigidbody>().isKinematic = false;

            cManager.grabing = false;
            key1 = false;
            key2 = false;
            sk1 = false;
            sk2 = false;
            sk3 = false;

        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3) && cManager.grabing == false)
        {


            if (Mouse.current.leftButton.wasPressedThisFrame)
            {


                Hited = hit.transform;

                if (hit.transform.tag == "Normal" && cManager.grabing == false)
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = Vector3.zero;
                    cManager.grabing = true;

                }


                if (hit.transform.tag == "Key1" && cManager.grabing == false)
                {
                    key1 = true;

                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = Vector3.zero;
                    cManager.grabing = true;

                }

                if (hit.transform.tag == "Key2" && cManager.grabing == false)
                {
                    key2 = true;

                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = new Vector3(0, 0.2f, 0);
                    cManager.grabing = true;

                }

                if (hit.transform.tag == "SK1" && cManager.grabing == false)
                {
                    sk1 = true;

                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = new Vector3(0, 0.2f, 0);
                    cManager.grabing = true;

                }

                if (hit.transform.tag == "SK2" && cManager.grabing == false)
                {
                    sk2 = true;

                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = new Vector3(0, 0.2f, 0);
                    cManager.grabing = true;

                }

                if (hit.transform.tag == "SK3" && cManager.grabing == false)
                {
                    sk3 = true;

                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                    hit.transform.SetParent(Hand);
                    hit.transform.localPosition = new Vector3(0, 0.2f, 0);
                    cManager.grabing = true;

                }

            }
        }

        //Keys

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out key, 3) && cManager.grabing == true)
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                if (key1 == true && key.transform.tag == "Sup1")
                {
                    Invoke("Bit2", 0.4f);
                    cManager.grabing = false;
                    Destroy(Lever2);
                    Lever.gameObject.SetActive(true);

                    Lever.GetComponent<Animator>().Play("LOpen");
                    Bars.GetComponent<Animator>().Play("Open");

                    Invoke("Bit1", 0.8f);


                    key1 = false;

                }

                if (key2 == true && key.transform.tag == "MoreHole")
                {
                    Invoke("Bit2", 0.5f);
                    cManager.grabing = false;
                    Destroy(Key2);

                    key.transform.GetComponent<Animator>().Play("Open");
                    Wall.transform.GetComponent<Animator>().Play("Fade");
                    key2 = false;

                    cMorse.start = true;

                }

                if (sk1 == true && key.transform.tag == "Hole1")
                {
                    Invoke("Bit2", 0.5f);
                    cManager.grabing = false;
                    Destroy(k1);

                    key.transform.GetComponentInChildren<Animator>().Play("Enter");

                    sk1 = false;
                    op++;

                }

                if (sk2 == true && key.transform.tag == "Hole2")
                {
                    Invoke("Bit2", 0.5f);
                    cManager.grabing = false;
                    Destroy(k2);

                    key.transform.GetComponentInChildren<Animator>().Play("Enter");

                    sk2 = false;
                    op++;

                }

                if (sk3 == true && key.transform.tag == "Hole3")
                {
                    Invoke("Bit2", 0.5f);
                    cManager.grabing = false;
                    Destroy(k3);

                    key.transform.GetComponentInChildren<Animator>().Play("Enter");

                    sk3 = false;
                    op++;

                }
            }

        }

        if (op == 3) { Invoke("OpenExit", 3); op++; }

        if (fl == true) { Finallight.intensity += 0.4f; }

        //chests

        if (Mouse.current.rightButton.wasPressedThisFrame && cManager.chest == true)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            BaseInput.gameObject.SetActive(false);
            targetScript.enabled = true;

            cManager.chest = false;
            prim = false;
            sec = false;
            third = false;

        }

        Invoke("P1", 0f);
        Invoke("P2", 0f);
        Invoke("P3", 0f);


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out open, 3) && cManager.chest == false)
        {


            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                if (open.transform.tag == "Puzzle1" && Once1 == true) { prim = true; Opened = open.transform; }
                if (open.transform.tag == "Puzzle2" && Once2 == true) { sec = true; Opened = open.transform; }
                if (open.transform.tag == "Fake" && Fake1 == true) { Chests.Play(); open.transform.GetComponent<Animator>().Play("Open"); Fake1 = false; open.transform.GetComponent<Collider>().enabled = false; Opened = open.transform; }
                if (open.transform.tag == "Wrong" && Nop == true) { Incorrect.Play(); open.transform.GetComponent<Animator>().Play("Open"); Nop = false; open.transform.GetComponent<Collider>().enabled = false; Invoke("Wait", 2f); cTimer.TimeLeft = cTimer.TimeLeft - 30; Opened = open.transform; }
                if (open.transform.tag == "Right" && Yup == true) { Correct.Play(); open.transform.GetComponent<Animator>().Play("Open"); Yup = false; open.transform.GetComponent<Collider>().enabled = false; Invoke("Wait", 2f); Opened = open.transform; }
                if (open.transform.name == "Pad" && Oncedoor == true) { third = true; Opened = open.transform; }
            }

        }



        //Read


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out read, 4))
        {
            if (read.transform.name == "ReadThis" && cLantern.On == true && stay == true)
            {
                Sread.Play();
                read.transform.gameObject.GetComponentInParent<Animator>().Play("Inv");
                Red = read.transform;
                inside = true;
                stay = false;
            }

            if (cLantern.On == false && stay == false)
            {
                Red.transform.gameObject.GetComponentInParent<Animator>().Play("Normal");
                stay = true;
            }
        }

        else
        {
            if (inside == true)
            {
                Red.transform.gameObject.GetComponentInParent<Animator>().Play("Normal");
                stay = true;
                inside = false;
            }
        }


    }

    void P1()
    {
        if (prim == true)
        {
            cManager.chest = true;

            Input = num1.text;

            BaseInput.gameObject.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            targetScript.enabled = false;

            if (Input == "321")
            {
                Chests.Play();
                StartCoroutine(Light());
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                BaseInput.gameObject.SetActive(false);
                Opened.GetComponent<Collider>().enabled = false;
                Opened.GetComponent<Animator>().Play("Open");
                targetScript.enabled = true;

                cManager.chest = false;
                Once1 = false;
                prim = false;
                num1.text = "";
            }
        }

    }
    public IEnumerator Light()
    {

        yield return new WaitForSeconds(1f);
        light2.intensity = 20;
        Lswitch.Play();
        yield return new WaitForSeconds(6f);
        light2.intensity = 0;
        yield return new WaitForSeconds(0.1f);
        light2.intensity = 20;
        yield return new WaitForSeconds(0.2f);
        light2.intensity = 0;
        yield return new WaitForSeconds(6f);
        light3.intensity = 30;
        yield return new WaitForSeconds(0.1f);
        light3.intensity = 0;
        yield return new WaitForSeconds(0.2f);
        light3.intensity = 30;


    }

    void P2()
    {
        if (sec == true)
        {
            cManager.chest = true;

            Input = num1.text;

            BaseInput.gameObject.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            targetScript.enabled = false;

            if (Input == "693")
            {
                Chests.Play();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                BaseInput.gameObject.SetActive(false);
                Opened.GetComponent<Collider>().enabled = false;
                Opened.GetComponent<Animator>().Play("Open");
                targetScript.enabled = true;

                cManager.chest = false;
                Once2 = false;
                sec = false;
                num1.text = "";
            }
        }

    }

    void P3()
    {
        if (third == true)
        {
            cManager.chest = true;

            Input = num1.text;

            BaseInput.gameObject.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            targetScript.enabled = false;

            if (Input == "285")
            {
                Correct.Play();
                Stonedoor.Play();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                BaseInput.gameObject.SetActive(false);
                DOOR.GetComponent<Animator>().Play("Open");
                targetScript.enabled = true;

                cManager.chest = false;
                Oncedoor = false;
                third = false;
                num1.text = "";
            }
        }

    }

    void Wait()
    {

        Opened.transform.GetComponent<Animator>().enabled = false;
        Yup = true;
        Nop = true;

    }

    public void OpenExit()
    {

        ExitGate.GetComponent<Animator>().Play("Open");
        fl = true;
        Stonedoor.Play();

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        targetScript.enabled = false;

        cTalking.TE = true;

        Invoke("E33", 16);
        Invoke("E3", 20);

    }

    void E3()
    {
        End3.gameObject.SetActive(true);
    }
    void E33()
    {
        White.gameObject.GetComponent<Animator>().Play("In");
    }



    void Bit1()
    {
        Barsup.Play();
    }

    void Bit2()
    {
        Keyswitch.Play();
    }
}
