using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NARRATORBULLETSCRIPT : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 15000;

    Vector3 moveDir;

    public float explosionRad;
    public bool playerDetected;

    [SerializeField] GameObject PlayerDetector;
    [SerializeField] GameObject Player;

    [SerializeField] ParticleSystem expoVFX;
    [SerializeField] AudioSource expoFX;



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

           
            if (other.CompareTag("Player"))
            {



                if (other.GetComponent<PlayerAttackScript>()!= null)
                {
                    if (other.gameObject.name.Contains("PlayerObject"))
                    {


                        other.GetComponent<PlayerAttackScript>().TakeDamage();

                    }

                   


                }



               // CanScript.instance.canAzal();


            }
            


            getEffect();
            PlayerDetector.GetComponent<SphereCollider>().enabled = true;


            destroyAttack();
        }
    }


    void getEffect()
    {

        expoVFX.Play();

        var cloneExpoVFX = Instantiate(expoVFX, transform.position, Quaternion.identity);
        print(cloneExpoVFX);

        expoVFX.Play();

       


    }

    void destroyAttack()
    {

        
        expoFX.Play();

        gameObject.GetComponent<MeshRenderer>().enabled = false;

        Invoke(nameof(destroySphere),0.5f);



    }

    void destroySphere()
    {


        Destroy(gameObject);

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
