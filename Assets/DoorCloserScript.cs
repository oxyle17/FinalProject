using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloserScript : MonoBehaviour
{
    [SerializeField] GameObject Door1;
    [SerializeField] GameObject Door2;

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
            Door1.GetComponent<RotateDoorScript>().Door1CloseTrigger();
            Door2.GetComponent<RotateDoorScript2>().Door1CloseTrigger();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
