using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour


   
{

    public static AmbientSound instance;

    [SerializeField] AudioSource ambient;
    void Start()
    {

        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        ambient.Play();



    }

}
