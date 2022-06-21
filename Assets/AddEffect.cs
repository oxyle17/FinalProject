using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEffect : MonoBehaviour
{


    public ParticleSystem toonSmoke;

    
    void Start()
    {
        toonSmoke = GetComponent<ParticleSystem>();
         
    }

   
    void Update()
    {
        
    }


   public void startEffect()
    {

        toonSmoke.Play();


         


    }

}


