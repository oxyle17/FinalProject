using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NaziMiceScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] NavMeshAgent NaziMice;
    [SerializeField] GameObject NaziDest;
    void Start()
    {
        NaziMice = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NaziMice.SetDestination(NaziDest.transform.position);
        }
    }
}
