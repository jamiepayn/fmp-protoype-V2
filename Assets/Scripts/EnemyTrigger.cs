using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
    }

   void OnTriggerEnter(Collider collision)
   {
       enemy.SetActive(true);
       Debug.Log("enemy activated");
   }
}
