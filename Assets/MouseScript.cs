using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseScript : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform Player;
    public LayerMask WhatIsGround, WhatIsPlayer;
    public Animator anim;

    public Vector3 WalkPoint;
    bool WalkPointSet;
    bool destinationSet;
    public float WalkPointRange = 10;

    public Animator animator;



    private void Awake()
    {





    }

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

            Idle();
        

    }


    private void Idle()
    {
        if (!WalkPointSet) SearchWalkPoint();

        if (WalkPointSet && !destinationSet)
        {
            //Debug.Log(destinationSet);
            Agent.SetDestination(WalkPoint);
            destinationSet = true;
        }



        Vector3 Distance2WalkPoint = transform.position - WalkPoint;

        if (Distance2WalkPoint.magnitude < 1)
        {
            WalkPointSet = false;
            destinationSet = false;
        }
    }
    
    private void SearchWalkPoint()
    {
        float RandomZ = Random.Range(-WalkPointRange, WalkPointRange);
        float RandomX = Random.Range(-WalkPointRange, WalkPointRange);

        WalkPoint = new Vector3(transform.position.x + RandomX, transform.position.y, transform.position.z + RandomZ);
        if (Physics.Raycast(WalkPoint, -transform.up, 2, WhatIsGround))
        {

            WalkPointSet = true;
        }

    }
    
}
