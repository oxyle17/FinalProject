using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NaziMiceScript : MonoBehaviour
{
    public static NaziMiceScript instance;


    [SerializeField] NavMeshAgent NaziMice;
    [SerializeField] GameObject NaziDest;
    void Start()
    {
        instance = this;
        NaziMice = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void MicetoExit()
    {


        NaziMice.SetDestination(NaziDest.transform.position);



    }


}
