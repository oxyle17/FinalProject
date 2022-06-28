using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitToTavern : MonoBehaviour
{
    public Transform TransformTo;
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

            Debug.Log(other.name);

            gameObject.transform.position = TransformTo.position;

        }

    }


}
