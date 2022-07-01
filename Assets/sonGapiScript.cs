using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonGapiScript : MonoBehaviour
{

    public Quaternion currentRot;
    public Quaternion currentRot2;

    [SerializeField] Vector3 rotationVar;
    public Quaternion openRot;
    public float doorSpeed;

    public bool opening;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        currentRot = gameObject.transform.localRotation;

        if (opening == true && gameObject.transform.rotation.y >= openRot.y)
        {
           
            transform.Rotate(rotationVar * doorSpeed * Time.deltaTime);

        }


      



    }

    public void OpenEndDoor()
    {

        EndDoorScript.instance.doorSound.Play();

        opening = true;

        EndDoorScript.instance.roomLight.SetActive(true);


    }

}
