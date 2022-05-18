using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Debug.Log("scene change");

            SceneManager.LoadScene("Hub", LoadSceneMode.Single);
        }

        

    }
}
