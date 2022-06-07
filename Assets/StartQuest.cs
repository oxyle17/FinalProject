using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuest : MonoBehaviour
{

    public Transform changeTo;

    [SerializeField] Canvas a1;
    [SerializeField] AudioSource s1;


    void Start()
    {

        a1.enabled = false;

    }

   


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            a1.enabled = false;


        }



    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {


            other.transform.position = changeTo.position;

            a1.enabled = true;
            s1.Play();




        }





    }

}
