using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChange : MonoBehaviour
{

   [SerializeField] private Material myMatLight;
   [SerializeField] private Material myMatDark;

    public GameObject enemyModel;
    public GameObject light;
    public GameObject darkMap;
    public GameObject fakeWall;
    public GameObject cube;
    

    public MeshRenderer buttonTrigger;

   public bool maskOn = false;

   void start()
   {
       myMatLight.color = Color.white;
       myMatDark.color = Color.black;
   }

   void Update()
   {
       if (Input.GetMouseButtonDown(0))
       {
            maskOn = !maskOn;
            Debug.Log(maskOn);
       }

        if(maskOn == false)
        {
            myMatLight.color = Color.white;
            myMatDark.color = Color.black;
            //darkMap.active = false;
            enemyModel.active = false;
            light.active = true;
            fakeWall.active = true;
            buttonTrigger.enabled = false;
            cube.SetActive(false);

        }

         if(maskOn == true)
        {
            myMatLight.color = Color.black;
            myMatDark.color = Color.white;
            //darkMap.active = true;
            enemyModel.active = true;
            light.active = false;
            fakeWall.active = false;
            buttonTrigger.enabled = true;
            cube.SetActive(true);


        }

      
   }
}
