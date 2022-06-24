using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiceExitScript : MonoBehaviour
{

    [SerializeField] float destroyCount;
    void Start()
    {
        
    }


    void Update()
    {

        if (destroyCount == 116)
        {
            Destroy(this);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        destroyCount++;
    }




}
