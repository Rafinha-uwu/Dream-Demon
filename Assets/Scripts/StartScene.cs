using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{

    public Light light1;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().Play("Lesgo");
        StartCoroutine(Beguin());
    }
    public IEnumerator Beguin()
    { 
        light1.intensity = 0;
        yield return new WaitForSeconds(24f);
        this.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        light1.intensity = 80;
        yield return new WaitForSeconds(0.1f);
        light1.intensity = 0;
        yield return new WaitForSeconds(0.1f);
        light1.intensity = 80;
        yield return new WaitForSeconds(0.2f);
        light1.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        light1.intensity = 80;

        yield return new WaitForSeconds(15f);
        light1.intensity = 0;
        yield return new WaitForSeconds(0.1f);
        light1.intensity = 70;
        yield return new WaitForSeconds(0.2f);
        light1.intensity = 0;
    }
}
