using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {

        if( col.gameObject.name == "Key 1" || col.gameObject.name == "Key 2" || col.gameObject.name == "Key 3" || col.gameObject.name == "Lever 2")
        {

            col.gameObject.GetComponent<Transform>().position = new Vector3(10, 69, 0);

        }
        else
        {

            col.gameObject.GetComponentInParent<Transform>().position = new Vector3(10, 69, 0);

        }
    }
}
