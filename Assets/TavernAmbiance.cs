using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernAmbiance : MonoBehaviour
{


    [SerializeField] AudioSource amb;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            amb.Play();




        }





    }

    private void OnTriggerExit(Collider other)
    {

        amb.Stop();

    }


}
