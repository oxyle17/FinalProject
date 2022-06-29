using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoorScript2 : MonoBehaviour
{
    [SerializeField] Vector3 rotationVar;
    public Quaternion openRot;
    public Quaternion closedRot;
    public Quaternion currentRot;
    public float doorSpeed;

    public bool opening;
    public bool closing;
    void Start()
    {
        closedRot = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = gameObject.transform.localRotation;

        if (opening && gameObject.transform.rotation.y >= openRot.y)
        {
            transform.Rotate(rotationVar * doorSpeed * Time.deltaTime);
        }

        if (closing && gameObject.transform.rotation.y <= closedRot.y)
        {
            transform.Rotate(-rotationVar * doorSpeed * Time.deltaTime);

        }
    }

    public void Door1OpenTrigger()
    {
        opening = true;
    }
    public void Door1CloseTrigger()
    {
        opening = false;
        closing = true;
    }
}
