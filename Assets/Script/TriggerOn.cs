using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TriggerOn : MonoBehaviour
{

    [SerializeField] AudioSource sound;
    [SerializeField] Canvas Text;
    

    void Start()
    {

        Debug.Log("TriggerOn");

        Text.enabled = false;
        sound = GetComponent<AudioSource>();
        

    }

   
    void Update()
    {

        if (sound.isPlaying == false)
        {

            Text.enabled = false;

           

        }



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
 sound.Play();
        Text.enabled = true;


        }
        
       
       
      



    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
             
            Destroy(this);

        }


     


    }


}
