using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitQuest1 : MonoBehaviour
{
    public Transform exitToQuest1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {


        if (Nazis.instance.Okay == true)
        {

            other.transform.position = exitToQuest1.position;

        }

    }

}
