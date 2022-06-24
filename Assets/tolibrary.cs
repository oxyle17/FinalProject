using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tolibrary : MonoBehaviour
{
    public Transform changeTo;
    public float count;
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

            count++;

            if (count == 1)
            {

            if (Nazis.instance.Okay == true)
             {
             other.transform.position = changeTo.position;
             }

                Destroy(this);

            }

           
           






        }





    }

}
