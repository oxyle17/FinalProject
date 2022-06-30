using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerAttackScript>().TakeDamage();
            GetComponent<SphereCollider>().enabled = false;
        }
    }
}
