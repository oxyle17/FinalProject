using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    [SerializeField] public GameObject FireBall;
    public Transform FirePoint;
    public Camera Cam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    public void Fire()
    {
        FireBall.transform.forward = FirePoint.transform.forward;
        GameObject bulletSpawned = Instantiate(FireBall, FirePoint.position, Quaternion.identity);
        bulletSpawned.transform.forward = FirePoint.transform.forward;

    }
}
