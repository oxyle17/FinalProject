using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuest : MonoBehaviour
{

    public Transform changeTo;

    [SerializeField] Canvas a1;



    void Start()
    {
        Debug.Log("StartQuest1");
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

            if (WomanTrigger2.instance.isAcceptQuest == true)
            {


                 other.transform.position = changeTo.position;

                  a1.enabled = true;
            }

           
           




        }





    }

}
