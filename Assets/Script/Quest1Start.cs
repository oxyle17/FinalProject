using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Quest1Start : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] GameObject house;
    public Vector3 houseTrans;

    





    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("QuestStart1");


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == houseTrans.x && transform.position.z == houseTrans.z)
        {
            Destroy(gameObject);
        }
    }

    public void Run2House()
    {

       


        houseTrans = house.transform.position;
        Debug.Log("RunHouse");
        agent.SetDestination(houseTrans);
        gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.numb;

    }
}
