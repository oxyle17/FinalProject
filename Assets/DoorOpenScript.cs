using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{

    [SerializeField] Vector3 DoorrotationVar;
    public Quaternion openRot;
    public Quaternion currentRot;
    public float doorSpeed;

    public bool opening;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentRot = gameObject.transform.localRotation;

        if (opening && gameObject.transform.rotation.y <= openRot.y)
        {
            transform.Rotate(DoorrotationVar * doorSpeed * Time.deltaTime);
        }

    }

    public void Door2OpenTrigger()
    {
        Debug.Log("sa");
        opening = true;
    }


}
