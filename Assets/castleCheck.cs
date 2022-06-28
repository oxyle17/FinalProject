using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castleCheck : MonoBehaviour
{
    [SerializeField] AudioSource guardS;
    [SerializeField] Canvas guardC;

    void Start()
    {
        guardC.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (guardS.isPlaying == false)
        {

            guardC.enabled = false;

        }

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {


            guardS.Play();
            guardC.enabled = true;

        }



    }

}
