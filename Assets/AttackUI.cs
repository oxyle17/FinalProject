using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackUI : MonoBehaviour
{

    public Canvas idle;
   

    void Start()
    {
        idle.enabled = true;
     


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {

            idle.enabled = false;
          

        }
        if (Input.GetKeyUp(KeyCode.E))
        {

            idle.enabled = true;
          
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
           
            idle.enabled = false;
            
        }


        if (Input.GetKeyUp(KeyCode.R))
        {
            idle.enabled = true;
            
        }


    }
}
