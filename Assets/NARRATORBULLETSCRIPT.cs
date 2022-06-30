using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NARRATORBULLETSCRIPT : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;
    Vector3 moveDir;

    [SerializeField] GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 10);
        Player = GameObject.FindGameObjectWithTag("Player");
        moveDir = (Player.transform.position - transform.position).normalized * speed * Time.deltaTime;
        rb.velocity = new Vector3(moveDir.x, moveDir.y, moveDir.z);
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
