using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject wall;

    public GameObject block;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cube")
        {
            wall.SetActive(false);
        }
    }
}
