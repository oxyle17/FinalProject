using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    [SerializeField] public GameObject FireBall;
    public Transform FirePoint;
    public Camera Cam;
    public GameObject FireEnabler;
    public float health = 3;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (MagicPower.CanFire == true)
            {
              Fire();
            }
        }
    }

    public void Fire()
    {
        FireBall.transform.forward = FirePoint.transform.forward;
        GameObject bulletSpawned = Instantiate(FireBall, FirePoint.position, Quaternion.identity);
        bulletSpawned.transform.forward = FirePoint.transform.forward;
    }

    public void TakeDamage()
    {
        health--;
    }

}
