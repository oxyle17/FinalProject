using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPower : MonoBehaviour
{

   [SerializeField] Canvas achiement;
   [SerializeField] AudioSource achiementSound;

    [SerializeField] ParticleSystem pickupEffect;
    public AudioSource pickupSound;


    public static MagicPower instance;

    void Start()
    {
        instance = this;
        achiement.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (achiementSound.isPlaying == false)
        {

            achiement.enabled = false;


        }
     

    }

    public void keepBook()
    {
        pickupSound.Play();


        pickupEffect.Play();

        var clonepickUpEffect = Instantiate(pickupEffect, transform.position, Quaternion.identity);

        print(clonepickUpEffect);

        pickupEffect.Play();


        gameObject.GetComponent<MeshRenderer>().enabled = false;


        achiementSound.Play();

        achiement.enabled = true;

        



    }

   
}
