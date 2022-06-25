using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("aaa");
        Destroy(gameObject);
    }
}
