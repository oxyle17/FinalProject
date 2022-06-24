using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class libraryExit : MonoBehaviour
{
    public Transform exitLibrary;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            if (epicbook.instante.Openexit == true)
            {

                other.transform.position = exitLibrary.position;



            }


        }


    }

}
