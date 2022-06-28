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

        if (other.CompareTag("Player"))
        {

            Debug.Log("a");

            Vector3 position = TransformTo.position;
            gameObject.transform.position = position;

        }

    }


}
