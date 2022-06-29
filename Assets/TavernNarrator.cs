using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernNarrator : MonoBehaviour
{
    [SerializeField] Canvas n1;
    [SerializeField] AudioSource s1;
    float count;
    void Start()
    {

        n1.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (s1.isPlaying == false)
        {

            n1.enabled = false;


        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            count++;

            if (count == 1)
            {

              n1.enabled = true;
              s1.Play();

            }

        }


    }


}



