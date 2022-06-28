using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookscene : MonoBehaviour
{

    public static bookscene instante;

    public Light cinematicLight;

    public AudioSource lacrimosa;

    [SerializeField] AudioSource a1;
    [SerializeField] Canvas c1;


    public bool open = false;
    float count;

    void Start()
    {
        instante = this;

        cinematicLight.enabled = false;

        c1.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (a1.isPlaying == false)
        {

            c1.enabled = false;

        }


    }

    private void OnTriggerEnter(Collider other)
    {
       
       


        if (other.CompareTag("Player"))
        {

             lacrimosa.Play();

           Invoke(nameof(openLight), 11.3f);

        }

        if (other.CompareTag("FireBall"))
        {
            count++;

            if (count == 1)
            {


                a1.Play();
                c1.enabled = true;



            }
           




        }



    }


    void openLight()
    {

        cinematicLight.enabled = true;
        open = true;

    }

}
