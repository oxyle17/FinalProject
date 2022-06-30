using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KingTrigger : MonoBehaviour
{

    public static KingTrigger instance;

    [SerializeField] Canvas k1;
    [SerializeField] Canvas k2;
    [SerializeField] Canvas k3;

    [SerializeField] Canvas ac1;
    [SerializeField] Canvas ac2;

    [SerializeField] AudioSource ks1; // king
    [SerializeField] AudioSource ks2;

    [SerializeField] AudioSource as1;
    [SerializeField] AudioSource as2;
    float count;

    public GameObject door;

    public bool missionStart;


    [SerializeField] Canvas tutorialCanvas;

   public AudioSource missionSound;


    public AudioSource effectSound1;
    public AudioSource effectSound2;


    void Start()
    {
        instance = this;

        k1.enabled = false;
        k2.enabled = false;

        k3.enabled = false;

        ac1.enabled = false;
        ac2.enabled = false;

        tutorialCanvas.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {

       


        if (missionStart == true)
        {

            if (Input.GetKey(KeyCode.E))
            {


                tutorialCanvas.enabled = false;
                door.SetActive(false);
            }

        }



        if (ks1.isPlaying == false)
        {

            k1.enabled = false;
            k2.enabled = false;


        }

        if (as1.isPlaying == false)
        {

            ac1.enabled = false;
           


        }

        if (as2.isPlaying == false)
        {

            ac2.enabled = false;



        }


        if (ks2.isPlaying == false)
        {

            k3.enabled = false;

        }



    }


    private void OnTriggerEnter(Collider other)
    {

        

        //4sn

        if (other.gameObject.CompareTag("Player"))
        {

            count++;


            if (count == 1)
            {

                a1();
               
                Invoke(nameof(a2), 5);

                Invoke(nameof(nar1), 10);

                Invoke(nameof(a3), 22);
                Invoke(nameof(nar2), 33.5f);
                Invoke(nameof(openCanvas), 44);

            }



        }




    }



    void a1()
    {
        ks1.Play();
        k1.enabled = true;


    }

    void a2()
    {

        k1.enabled = false;
        k2.enabled = true;




    }

    void a3()
    {


        ks2.Play();
        k3.enabled = true;
       




    }



    void nar1()
    {

        ac1.enabled = true;
        as1.Play();


    }
    void nar2()
    {

        ac2.enabled = true;
        as2.Play();


    }


    void openCanvas()
    {


        tutorialCanvas.enabled = true;

        missionSound.Play();

        missionStart = true;

        gameObject.tag = "MaxSpeed";



    }


   

}
