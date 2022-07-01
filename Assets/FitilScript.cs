using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitilScript : MonoBehaviour
{
    public bool JustFired;
    [SerializeField] GameObject NARRATOR;


    [SerializeField] AudioSource fireSound;
    [SerializeField] AudioSource bossStanSound;

    [SerializeField] ParticleSystem fireVFX;

    [SerializeField] GameObject fireLoc;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FireBall"))
        {
            JustFired = true;
            FireCannon();

        }
    }
    public void FireCannon()
    {
        //Kaan buraya ateş sesi
        NARRATOR.GetComponent<NARRATORSCRIPT>().Cannonned();
        getEffect();
        
    }



    public void getEffect()
    {
        fireSound.Play();

        fireVFX.Play();

        var cloneFireVFX = Instantiate(fireVFX, fireLoc.transform.position, Quaternion.identity);
        print(cloneFireVFX);

        fireVFX.Play();

        Invoke(nameof(stanSound), 1);


    }

    void stanSound()
    {


        bossStanSound.Play();
    }

}
