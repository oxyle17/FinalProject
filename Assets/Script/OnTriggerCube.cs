using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCube : MonoBehaviour
{
    [SerializeField] GameObject a;
    void Start()
    {

        a.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {



      

    }
    

    private void OnTriggerEnter(Collider other)
    {

        a.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        a.SetActive(false);
    }
}
