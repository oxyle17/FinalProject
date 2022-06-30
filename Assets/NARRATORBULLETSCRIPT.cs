using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NARRATORBULLETSCRIPT : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;
    Vector3 moveDir;

    public float explosionRad;
    public bool playerDetected;

    [SerializeField] GameObject PlayerDetector;
    [SerializeField] GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 30);

        Player = GameObject.FindGameObjectWithTag("Player");
        moveDir = (Player.transform.position - transform.position).normalized * speed * Time.deltaTime;
        rb.velocity = new Vector3(moveDir.x, moveDir.y, moveDir.z);
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("FireBall"))
        {
            //Check4Player();
            PlayerDetector.GetComponent<SphereCollider>().enabled = true;
            Destroy(gameObject, 1);
        }
    }

    //public void Check4Player()
    //{
    //    Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRad);
    //    foreach (Collider c in colliders)
    //    {
    //        Debug.Log(c.name);
    //        if (c.CompareTag("Player"))
    //        {
    //            c.GetComponent<PlayerAttackScript>().TakeDamage();
    //        }
    //    }
    //}
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(transform.position, explosionRad);
    //}
}
