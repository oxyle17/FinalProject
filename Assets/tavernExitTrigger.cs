using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tavernExitTrigger : MonoBehaviour
{

    [SerializeField] Canvas a1;
    [SerializeField] AudioSource s1;
    float count;

    void Start()
    {

        a1.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (s1.isPlaying == false)
        {

            a1.enabled = false;

        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (serseri.instance.okey == true)
            {
                count++;

                if (count == 1)
                {

                    a1.enabled = true;
                    s1.Play();



                }



            }

        }



    }


}
