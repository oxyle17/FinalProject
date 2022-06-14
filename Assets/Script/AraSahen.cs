using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AraSahen : MonoBehaviour
{
    public static AraSahen instance;
    public GameObject Women;
    public Transform changeTo;
    public Transform changeTo2;

    public AudioSource quest1Music;
    public GameObject Player;

    [SerializeField] Canvas women1;
    [SerializeField] Canvas women2;

    [SerializeField] AudioSource ws1;
    [SerializeField] AudioSource ws2;

   

    
    void Start()
    {
        Women.GetComponent<MeshRenderer>().enabled = false;
        instance = this;

        women1.enabled = false;
        women2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (ws1.isPlaying == false)
        {

            women1.enabled = false;

        }

        if (ws2.isPlaying == false)
        {

            women2.enabled = false;
        }



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

        Invoke(nameof(sahne2), 6);



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

    public void TransformPlayer2()
    {

        Player.transform.position = changeTo2.position;

    }

    public void womenActive()
    {

        Women.GetComponent<MeshRenderer>().enabled = true;


    }


    public void sahne2()
    {

        womenTalk1();

        Invoke(nameof(womenTalk2), 14);

        Invoke(nameof(FadeIn), 33);

        Invoke(nameof(getOut), 35);


    }

    void womenTalk1()
    {
        women1.enabled = true;
        ws1.Play();



    }
    void womenTalk2()
    {
        women2.enabled = true;
        ws2.Play();

    }

    void getOut()
    {

        TransformPlayer2();
        Invoke(nameof(fadeOut), 1);



    }

}
