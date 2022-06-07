using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("fdkj");
        if (other.CompareTag("NPC"))
        {
            Destroy(other.gameObject);
            Debug.Log("sdf");
        }

    }
}
