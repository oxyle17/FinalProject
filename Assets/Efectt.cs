using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efectt : MonoBehaviour
{
    public ParticleSystem smoke;
    public AudioSource smokeSound;

    public static Efectt instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void openSmoke()
    {

        smokeSound.Play();


        smoke.Play();

        var cloneCloudVFX = Instantiate(smoke, transform.position, Quaternion.identity);
        print(cloneCloudVFX);

        smoke.Play();

    }

}
