using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerKill : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(player);
            Debug.Log("player hit");
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

        Debug.Log("something hit");

    }
}
