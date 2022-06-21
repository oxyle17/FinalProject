using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiceofNazi : MonoBehaviour
{

    public static MiceofNazi instance;

    [SerializeField] AudioSource nms1;
    [SerializeField] Canvas nmc1;
    
    [SerializeField] AudioSource ns1;

    [SerializeField] Canvas nc1;


    void Start()
    {
        instance = this;
        nmc1.enabled = false;
        nc1.enabled = false;

    }

    
    void Update()
    {

        if (nms1.isPlaying == false)
        {

            nmc1.enabled = false;
        }

        if (ns1.isPlaying == false)
        {

            nc1.enabled = false;
        }

    }


    private void OnTriggerEnter(Collider other)
    {

        nm();
        Invoke(nameof(nar1), 9);

       



    }


    void nm()
    {

        nms1.Play();
        nmc1.enabled = true;



    }


    void nar1()
    {

        ns1.Play();
        nc1.enabled = true;

    }



    private void OnTriggerExit(Collider other)
    {

        Invoke(nameof(destoryCube), 13);



    }

    void destoryCube()
    {

        Destroy(this);


    }

}
