using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NaziMiceScript : MonoBehaviour
{

   

    public static NaziMiceScript instance;
    public bool anan;


    public NavMeshAgent NaziMice;
    public GameObject NaziDest;

    void Start()
    {
        instance = this;
        NaziMice = GetComponent<NavMeshAgent>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //aaaaaaaaaaaaaaaaaaaaaaa fuck
    public void MicetoExit()
    {
        
        

           
        NaziMice.SetDestination(NaziDest.transform.position);
        Debug.Log(gameObject.transform.position);
        
        



    }


}
