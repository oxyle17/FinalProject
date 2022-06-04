using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackUI : MonoBehaviour
{

    public Canvas idle;
    public Canvas Attack1;
    public Canvas Attack2;

    void Start()
    {
        idle.enabled = true;
        Attack1.enabled = false;
        Attack2.enabled = false;
        


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {

            idle.enabled = false;
            Attack1.enabled = true;
            Attack2.enabled = false;


        }
        if (Input.GetKeyUp(KeyCode.E))
        {

            idle.enabled = true;
            Attack1.enabled = false;
            Attack2.enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            Attack2.enabled = true;
            idle.enabled = false;
            Attack1.enabled = false;
        }


        if (Input.GetKeyUp(KeyCode.R))
        {
            Attack2.enabled = false;
            idle.enabled = true;
            Attack1.enabled = false;
        }


    }
}
