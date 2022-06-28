using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitQuest1 : MonoBehaviour
{
    public static exitQuest1 instance;

    public Transform exitToQuest1;


    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {


        if (AnlatýcýScript.instance.acs == true)
        {
           
            other.transform.position = exitToQuest1.position;
            

        }

    }

}
