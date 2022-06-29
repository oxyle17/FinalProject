using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serseri : MonoBehaviour
{
    [SerializeField] Canvas serseri1;

    [SerializeField] Canvas serseri2;

   

    [SerializeField] AudioSource serseriSound1;
    [SerializeField] AudioSource serseriSound2;
    float count;
    

    void Start()
    {

        


        gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.numb;



        serseri1.enabled = false;
        serseri2.enabled = false;
       


    }

    // Update is called once per frame
    void Update()
    {
        if (serseriSound1.isPlaying == false)
        {

            serseri1.enabled = false;

        }

        if (serseriSound2.isPlaying == false)
        {

            serseri2.enabled = false;

        }


       

            if (BJGameManager.instance.endOfGame == true)
            {
            count++;


            if (count == 1)
            {
                 gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.numb;

                a2();
            }
                



            }





    }

    void openNumb()
    {

        gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.quest2Start;


    }

    void a1()
    {

        serseri1.enabled = true;
        serseriSound1.Play();
    }


    void a2()
    {

        serseri2.enabled = true;
        serseriSound2.Play();
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            a1();
            Invoke(nameof(openNumb), 4);

           

        }


    }

    


   

}
