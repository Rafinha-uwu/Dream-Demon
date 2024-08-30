using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talking : MonoBehaviour
{

    public bool TO = false;
    public bool TO1 = true;

    public bool Hint = false;
    public bool Hint1 = true;

    public bool FE = false;
    public bool FE1 = true;

    public bool TE = false;
    public bool TE1 = true;

    public AudioSource Badvoice;
    public AudioSource Goodvoice;
    public AudioSource Badvoice2;
    public AudioSource Goodvoice2;
    public AudioSource Demon;
    public AudioSource Eaten;

    public GameObject Good;
    public GameObject Bad;
    public TMP_Text Goodtext;
    public TMP_Text Badtext;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Intro());     
    }

    // Update is called once per frame
    void Update()
    {
        if(TO == true && TO1 == true)
        {
            StartCoroutine(TimeOut());
        }

        if (Hint == true && Hint1 == true)
        {
            StartCoroutine(Hinta());
        }
        if (FE == true && FE1 == true)
        {
            StartCoroutine(FirstExit());
        }
        if (TE == true && TE1 == true)
        {
            StartCoroutine(TrueExit());
        }



    }

    public IEnumerator Hinta()
    {
        Hint1 = false;
        Good.gameObject.SetActive(true);
        Goodvoice.Play();
        Goodtext.SetText("Be careful");
        yield return new WaitForSeconds(4f);
        Goodvoice.Play();
        Goodtext.SetText("Opening the wrong chest removes 30 seconds from the timer");
        yield return new WaitForSeconds(4f);
        Goodvoice.Play();
        Goodtext.SetText("Look for hints everywhere");
        yield return new WaitForSeconds(4f);
        Good.gameObject.SetActive(false);
    }

        public IEnumerator Intro()
    {
        yield return new WaitForSeconds(3f);
        Bad.gameObject.SetActive(true);
        Badvoice.Play();
        Badtext.SetText ("Welcome mortal");
        yield return new WaitForSeconds(4f);
        Badvoice.Play();
        Badtext.SetText("Yes, you're still dreaming");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("I've traped you here in your dreams");
        yield return new WaitForSeconds(4f);
        Badvoice.Play();
        Badtext.SetText("Don't worry.. just try and get out");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("You got 15 minutes");
        yield return new WaitForSeconds(4f);

        Bad.gameObject.SetActive(false);
        yield return new WaitForSeconds(6f);


        Good.gameObject.SetActive(true);
        Goodvoice.Play();
        Goodtext.SetText("Hey.. I think he's gone");
        yield return new WaitForSeconds(4f);
        Goodvoice.Play();
        Goodtext.SetText("We're the past victims of this demon");
        yield return new WaitForSeconds(4f);
        Goodvoice2.Play();
        Goodtext.SetText("We'll help you get out");
        yield return new WaitForSeconds(4f);
        Goodvoice2.Play();
        Goodtext.SetText("Press E to turn on your Lantern");
        yield return new WaitForSeconds(4f);
        Goodvoice.Play();
        Goodtext.SetText("You'll find hidden messages in the walls");
        yield return new WaitForSeconds(4f);
        Goodvoice2.Play();
        Goodtext.SetText("Good luck... don't trust him");
        yield return new WaitForSeconds(4f);
        Good.gameObject.SetActive(false);

    }

    public IEnumerator TimeOut()
    {
        TO1 = false;
        Demon.Play();
        Bad.gameObject.SetActive(true);
        Badvoice.Play();
        Badtext.SetText("Oh..");
        yield return new WaitForSeconds(4f);
        Badvoice.Play();
        Badtext.SetText("Time's Up");
        yield return new WaitForSeconds(4f);
        Eaten.Play();


        Bad.gameObject.SetActive(false);
       

    }

    public IEnumerator FirstExit()
    {
        FE1 = false;
        Demon.Play();
        Bad.gameObject.SetActive(true);
        Badvoice.Play();
        Badtext.SetText("You made it");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("But there's something I must tell you");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("This passage doesn't let you out");
        yield return new WaitForSeconds(4f);
        Badvoice.Play();
        Badtext.SetText("This passage.. let's me in");
        yield return new WaitForSeconds(4f);
        Eaten.Play();


        Bad.gameObject.SetActive(false);


    }

    public IEnumerator TrueExit()
    {
        TE1 = false;
        Demon.Play();
        Bad.gameObject.SetActive(true);
        Badvoice.Play();
        Badtext.SetText("Wait... no");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("What are you doing");
        yield return new WaitForSeconds(4f);
        Badvoice2.Play();
        Badtext.SetText("HOW DARE YOU ESCAPE");
        yield return new WaitForSeconds(4f);
        Badvoice.Play();
        Badtext.SetText("NOOOOO");
        yield return new WaitForSeconds(4f);

        Bad.gameObject.SetActive(false);


    }

}
