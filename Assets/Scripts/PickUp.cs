using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;

    void Update()
    {
        if(Input. GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }

        if(Input. GetMouseButtonUp(1))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    /*void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }   */
}
