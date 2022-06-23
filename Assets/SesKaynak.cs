using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKaynak : MonoBehaviour
{
    [SerializeField] AudioSource denem1;
    [SerializeField] AudioSource denem2;



    public ParticleSystem miceVFX;
   



    public static SesKaynak instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Anan1()
    {



        denem1.Play();
        denem2.Play();

    }

   
   



}
