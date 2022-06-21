using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazis : MonoBehaviour
{

    public static Nazis instance;
    //public GameObject[] enemies;
   

    [SerializeField] Canvas naziCanvas1;
    [SerializeField] Canvas naziCanvas2;
    [SerializeField] Canvas naziCanvas3;

    [SerializeField] AudioSource naziSound1;
    [SerializeField] AudioSource naziSound2;
    [SerializeField] AudioSource naziSound3;
    [SerializeField] AudioSource naziSound4;

    [SerializeField] Canvas narratorCanvas1;
    [SerializeField] AudioSource narratorSound1;

    [SerializeField] Canvas narratorCanvas2;
    [SerializeField] AudioSource narratorSound2;


    [SerializeField] GameObject barrier;




    void Start()
    {
        instance = this;

        naziCanvas1.enabled = false;
        naziCanvas2.enabled = false;
        naziCanvas3.enabled = false;
        narratorCanvas1.enabled = false;

        narratorCanvas2.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (naziSound1.isPlaying == false)
        {

            naziCanvas1.enabled = false;

        }
        if (naziSound2.isPlaying == false)
        {

            naziCanvas2.enabled = false;

        }
        if (naziSound3.isPlaying == false)
        {

            naziCanvas3.enabled = false;

        }

        if (narratorSound1.isPlaying == false)
        {

            narratorCanvas1.enabled = false;

        }

        if (narratorSound2.isPlaying == false)
        {

            narratorCanvas2.enabled = false;

        }




    }



    void m1()
    {

        naziSound1.Play();
        naziCanvas1.enabled = true;

    }

    void m2()
    {

        naziSound2.Play();
        naziCanvas2.enabled = true;

    }

    void m3()
    {

        naziSound3.Play();
        naziCanvas3.enabled = true;

    }

    void n1()
    {


        narratorSound1.Play();
        narratorCanvas1.enabled = true;


    }


    void n2()
    {


        narratorSound2.Play();
        narratorCanvas2.enabled = true;


    }




    private void OnTriggerEnter(Collider other)
    {

        m1();
        Invoke(nameof(n1), 22);
        Invoke(nameof(m3), 27);
        Invoke(nameof(hareket), 53);
        Invoke(nameof(n2), 53);

        Invoke(nameof(openBarrier), 63);



    }



    void playSound()
    {

        naziSound4.Play();


    }

    void hareket()
    {
        NaziMiceScript[] enemies = FindObjectsOfType<NaziMiceScript>();

        foreach (NaziMiceScript enemy in enemies)
        {
            enemy.MicetoExit();

        }





    }

    void openBarrier()
    {


        Destroy(barrier);



    }


    private void OnTriggerExit(Collider other)
    {


        Destroy(this);

    }



}
