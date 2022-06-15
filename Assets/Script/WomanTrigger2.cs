using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanTrigger2 : MonoBehaviour
{
    [SerializeField] Canvas woman2;
    [SerializeField] AudioSource womanSound;
    [SerializeField] Canvas mark;

    void Start()
    {
        mark.enabled = false;
        woman2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (womanSound.isPlaying == false)
        {

            woman2.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            mark.enabled = false;

        }

    }

    private void OnTriggerEnter(Collider other)
    {


        gameObject.GetComponent<BoxCollider>().enabled = false;

        womanSound.Play();
        woman2.enabled = true;


        Invoke(nameof(marko), 12);

        

    }

    public void marko() 
    {

        mark.enabled = true;
       
        
    
    }



}
