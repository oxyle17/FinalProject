using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    Vector3 TargetPos;

    public bool isArrive = false;


    void Start()
    {
        TargetPos = transform.position;
        TargetPos.z += 9;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(aaa());
    }

    public IEnumerator aaa()
    {

        for (; ; )
        {
            yield return new WaitForSeconds(0.1f);
            transform.position = Vector3.MoveTowards(transform.position, TargetPos, 25 * Time.deltaTime);
           




        }


    }


    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
    }

}