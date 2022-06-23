using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tolibrary : MonoBehaviour
{
    public Transform changeTo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            if (Nazis.instance.Okay == true)
            {
             other.transform.position = changeTo.position;
            }
           






        }





    }

}
