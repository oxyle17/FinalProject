using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthVfxScript : MonoBehaviour
{
    [SerializeField] ParticleSystem expoVFX;
    [SerializeField] GameObject vfxLoc;
    void Start()
    {
        Invoke(nameof(getEffect), 3);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getEffect()
    {


        expoVFX.Play();

        var cloneExpoVFX = Instantiate(expoVFX, vfxLoc.transform.position, Quaternion.identity);
        print(cloneExpoVFX);

        expoVFX.Play();

       


    }

}
