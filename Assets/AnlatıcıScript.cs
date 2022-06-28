using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnlatıcıScript : MonoBehaviour
{
    [SerializeField] AudioSource anlaticiP1;
    [SerializeField] Canvas anlaticiCanvas;
    [SerializeField] Canvas anlaticiCanvas2;

    public static AnlatıcıScript instance;

    public bool acs = false;
    float count;

    void Start()
    {
        
        anlaticiCanvas.enabled = false;
        anlaticiCanvas2.enabled = false;
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        if (anlaticiP1.isPlaying == false)
        {
            anlaticiCanvas.enabled = false;
            anlaticiCanvas2.enabled = false;


        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (Nazis.instance.Okay == true)
            {


                count++;
                if (count == 1)
                {
                    anlaticiP1.Play();
                    anlaticiCanvas.enabled = true;

                    Invoke(nameof(p2), 15);

                    Invoke(nameof(exitAcces), 26);

                }


            }


        }

    }

    void p2()
    {

        anlaticiCanvas.enabled = false;
        anlaticiCanvas2.enabled = true;
        

    }


    void exitAcces()
    {

        acs = true;





    }

}
