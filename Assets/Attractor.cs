using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
   

    public static List<Attractor> Attractors;

    

     public Rigidbody rb;


    private void Start()
    {

        rb.useGravity = true;
       

    }


    void CloseGravity()
    {

        rb.useGravity = false;


    }
    private void FixedUpdate()
    {

        

        foreach (Attractor attractor in Attractors)
        {


            if (attractor != this) 
            {

              Attract(attractor);


            }
           

        }


    }

    void OnEnabled()
    {
        if (Attractors == null)
            Attractors = new List<Attractor>();


        Attractors.Add(this);



    }


    void OnDisabled()
    {


        Attractors.Remove(this);



    }


    void Attract(Attractor objToAttract)
    {


        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;

        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 20);

        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);


    }

    private void OnCollisionEnter(Collision collision)
    {

        CloseGravity();

    }


}
