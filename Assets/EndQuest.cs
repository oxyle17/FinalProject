using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndQuest : MonoBehaviour
{

    public static EndQuest instance;
    [SerializeField] AudioSource women1;

    [SerializeField] Canvas womenCanvas;

    public GameObject a;

    float count;
    public bool a1;

    void Start()
    {
        instance = this;

        a.SetActive(false);

        womenCanvas.enabled = false;


    }
    

    // Update is called once per frame
    void Update()
    {

        if (StartQuest.instance.enter == true)
        {

            a.SetActive(true);


        }


        if (MagicPower.instance.canExit == true)
        {

            Destroy(this);

        }


        if (MagicPower.instance.CanFire == true)
        {

            Destroy(this);


        }

        if (women1.isPlaying == false)
        {

            womenCanvas.enabled = false;
        }



    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            if (StartQuest.instance.enter == true)
            {


              count++;

            if (count == 1)
            {

               women1.Play();
               womenCanvas.enabled = true;
               a1 = true;

            }


            }

            

            


        }



    }





}
