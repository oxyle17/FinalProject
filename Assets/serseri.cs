using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serseri : MonoBehaviour
{

    public static serseri instance;

    [SerializeField] Canvas serseri1;

    [SerializeField] Canvas serseri2;

    public bool okey;

    [SerializeField] AudioSource serseriSound1;
    [SerializeField] AudioSource serseriSound2;
    float count;
    float gameCount;
    

    void Start()
    {

        instance = this;


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
                 Invoke(nameof(a2), 2);
                
                okey = true;
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
            gameCount++;

            if (gameCount == 1)
            {
             a1();
             Invoke(nameof(openNumb), 4);
            }

           

           

        }


    }

    


   

}
