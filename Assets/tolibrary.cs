using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tolibrary : MonoBehaviour
{
    public Transform changeTo;
    public float count;

    public GameObject duman;

    
    // Start is called before the first frame update
    void Start()
    {
        duman.SetActive(false);
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

            if (EndQuest.instance.a1 == true)
             {
               other.transform.position = changeTo.position;
               duman.SetActive(true);


             }

                

            }

           
           






        }





    }

}
