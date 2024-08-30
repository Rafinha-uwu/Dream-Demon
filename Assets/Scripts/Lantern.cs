using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lantern : MonoBehaviour
{

    public GameObject Holder;
    public bool On = false;

    // Start is called before the first frame update
    void Start()
    {
        Holder.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (On) 
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                this.GetComponent<AudioSource>().Play();
                Holder.gameObject.SetActive(false);
                On = false;
            }
        }

        else 
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                this.GetComponent<AudioSource>().Play();
                Holder.gameObject.SetActive(true);
                On = true;
            }
        }
        
    }
}
