using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anlaticip2 : MonoBehaviour
{

    [SerializeField] Canvas part2;
    [SerializeField] AudioSource sound2;

    float count;
    void Start()
    {
        
        part2.enabled = false;



    }

    // Update is called once per frame
    void Update()
    {

        if (sound2.isPlaying == false)
        {

            part2.enabled = false;
        }



    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            if (MagicPower.instance.canExit == true)
            {
                count++;

                if (count == 1)
                {

                    part2.enabled = true;
                    sound2.Play();


                }


            }

        }


    }


}
