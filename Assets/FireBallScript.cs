using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;

    public ParticleSystem smoke;
    public ParticleSystem fire;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed * Time.deltaTime;
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("CanFire")) // Kütüphane
        {
            Destroy(gameObject);
            getSmoke();
            getFire();
        }
        
        Destroy(gameObject);


        

        
       
    }

    public void getSmoke()
    {
        smoke.Play();

        var clonesmokeVFX = Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
        print(clonesmokeVFX);

        smoke.Play();





    }

    public void getFire()
    {

        fire.Play();
        var cloneFire = Instantiate(fire,gameObject.transform.position, Quaternion.identity);
        print(cloneFire);

        fire.Play();



    }



}
