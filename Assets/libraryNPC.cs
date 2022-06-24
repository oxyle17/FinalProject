using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class libraryNPC : MonoBehaviour
{

    public static libraryNPC instance;

    public NavMeshAgent agent;
    public GameObject desk;
    public Vector3 deskTrans;

    [SerializeField] Animator walk;


    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void WalkTodesk()
    {

       

        deskTrans = desk.transform.position;
        walk.SetTrigger("Npc2Anim");
        agent.SetDestination(deskTrans);
       


    }
}

