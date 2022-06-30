using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public Transform theDest;

    

    private void Start()
    {
        Debug.Log("Pickup");
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {



            PuttingDown();
        }
    }

    public void PickingUp()
    {
      


        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = theDest.position;
        transform.parent = GameObject.Find("Destination").transform;
    }

    public void PuttingDown()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }

    



}
