using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeroGravity : MonoBehaviour
{
    public Collider coll;

    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Fly"))
        {

            other.attachedRigidbody.useGravity = false;
        }

       

    }


}
