using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCastle : MonoBehaviour
{
    
    public Transform Teleport;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            gameObject.transform.position = Teleport.position;

        }

    }


}
