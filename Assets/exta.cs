using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exta : MonoBehaviour
{
    public Transform changeTo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

           // MagicPower.CanFire = true;
            other.transform.position = changeTo.position;



        }

    }
}
