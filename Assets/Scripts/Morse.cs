using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morse : MonoBehaviour
{
    public bool first = true;
    public bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true && first == true)
        {
            StartCoroutine(pisca());
        }
    }

    public IEnumerator pisca()
    {

        first = false;

        //2

        yield return new WaitForSeconds(5f);
        this.GetComponent<AudioSource>().Play();
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;


        //8

        yield return new WaitForSeconds(3f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(1.2f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;

        //5

        yield return new WaitForSeconds(3f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 20;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Light>().intensity = 0;

        first = true;

    }
}
