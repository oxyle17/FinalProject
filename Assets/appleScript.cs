using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed * Time.deltaTime;
    }
}
