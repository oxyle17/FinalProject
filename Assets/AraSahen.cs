using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AraSahen : MonoBehaviour
{
    public static AraSahen instance;
    public GameObject Women;
    public Transform changeTo;

    public AudioSource quest1Music;
    public GameObject Player;

   

    
    void Start()
    {
        Women.GetComponent<MeshRenderer>().enabled = false;
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Quest1"))
        {


            quest1Music.Play();


        }

    }

    public void Sahne1()
    {

        FadeIn();

        Invoke(nameof(TransformPlayer), 2);




        Invoke(nameof(fadeOut), 3);

        Invoke(nameof(womenActive), 3);


    }


    public void fadeOut()
    {
        PlayerInteract.instance._done = true;
    }

    public void FadeIn()
    {

        PlayerInteract.instance._done = false;

    }

    public void TransformPlayer()
    {

        Player.transform.position = changeTo.position;

    }

    public void womenActive()
    {

        Women.GetComponent<MeshRenderer>().enabled = true;


    }
}
