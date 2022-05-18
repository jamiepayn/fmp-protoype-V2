using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueUI;

    public GameObject audio;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);

        
    }

    void OnTriggerEnter(Collider collision)
    {
        dialogueUI.SetActive(true);

        GetComponent<AudioSource>().Play();

        if (Input.GetKey("e"))
        {
            
        }
    }

    void OnTriggerExit(Collider collision)
   {
       dialogueUI.SetActive(false);

       Debug.Log("dialogue disabled");

       
    }

}
