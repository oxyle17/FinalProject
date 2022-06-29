using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCastle : MonoBehaviour
{

    public Canvas g1;
    public AudioSource s1;

    public Transform Teleport;
    
    void Start()
    {
        g1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (s1.isPlaying == false)
        {

            g1.enabled = false;
        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (serseri.instance.okey == true)
            {

              other.transform.position = Teleport.position;

            }
            else
            {

                s1.Play();
                g1.enabled = true;



            }

           



        }

    }

}
