using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class libraryNPC : MonoBehaviour
{

    public static libraryNPC instance;

    [SerializeField] NavMeshAgent agent;
    [SerializeField] GameObject desk;
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

        walk.SetTrigger("NPCAnim");

        deskTrans = desk.transform.position;
        agent.SetDestination(deskTrans);

        

    }
}
