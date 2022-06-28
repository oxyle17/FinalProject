using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{


    [SerializeField] AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           sound.Play();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
 sound.Stop();
        }
       


    }

}
