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
    public float minWalkPointRange = 7;
    public float WalkPointRange = 10;

    public Animator animator;

    public float decisionInterval = 0.3f;
    public float timeSinceLastDecision = 1;


    private void Awake()
    {



        // 19746 484 -13203

    }

    void Start()
    {

       

        Debug.Log("MouseScript");
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Idle();
        

    }


    private void Idle()
    {
        timeSinceLastDecision += Time.deltaTime;

        if (!WalkPointSet || timeSinceLastDecision > decisionInterval) SearchWalkPoint();

        if (WalkPointSet)
        {


            
            Agent.SetDestination(WalkPoint);

            
        }



        Vector3 Distance2WalkPoint = transform.position - WalkPoint;

        if (Distance2WalkPoint.magnitude < 1)
        {
            WalkPointSet = false;
            
        }
    }
    
    private void SearchWalkPoint()
    {
        timeSinceLastDecision = 0;


        float RandomZ = Random.Range(-WalkPointRange, WalkPointRange);
        float RandomX = Random.Range(-WalkPointRange, WalkPointRange);

        WalkPoint = new Vector3(transform.position.x + RandomX, transform.position.y, transform.position.z + RandomZ);
        if (Physics.Raycast(WalkPoint, -transform.up, 2, WhatIsGround))
        {

            WalkPointSet = true;
        }

    }
    
}
