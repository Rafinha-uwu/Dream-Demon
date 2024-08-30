using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Feet : MonoBehaviour
{
    Talking cTalking;
    public GameObject CTalking;

    public GameObject End2;
    public GameObject Black;

    public MonoBehaviour targetScript;

    public bool oncehint = false;

    // Start is called before the first frame update
    void Start()
    {
        cTalking = CTalking.GetComponent<Talking>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "tp")
        {
            this.gameObject.GetComponentInParent<CharacterController>().enabled = false;
            this.gameObject.GetComponentInParent<CharacterController>().transform.position = new Vector3(10, 69, 0);
            this.gameObject.GetComponentInParent<CharacterController>().enabled = true;
        }

        if (col.name == "Touch2")
        {
            cTalking.FE = true;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            targetScript.enabled = false;

            
            Invoke("E22", 16);
            Invoke("E2", 20);
        }

        if (col.name == "Hint" && oncehint == false)
        {

            cTalking.Hint = true;
            oncehint = true;
        }
    }

    void E2()
    {
        End2.gameObject.SetActive(true);
    }
    void E22()
    {
        Black.gameObject.GetComponent<Animator>().Play("In");
    }

}

