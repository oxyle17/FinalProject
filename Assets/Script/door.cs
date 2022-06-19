using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    //    public int openCount;

    public Vector3 openPos;
    public Vector3 closePos;
    public bool isOpening = false;
    public bool isClosing = false;
    public float doorSpeed;

    void Start()
    {
        //Debug.Log("Door");


    }
    private void Update()
    {
        if (isOpening)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, openPos, Time.deltaTime * doorSpeed);
        }
        else if (isClosing)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, closePos, Time.deltaTime * doorSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isOpening = true;
        isClosing = false;
    }

    private void OnTriggerExit(Collider other)
    {
        isClosing = true;
        isOpening = false;
    }

    

    //    public void Open()
    //    {


    //        isOpen = true;




    //    }




    //    // Update is called once per frame
    //    void Update()
    //    {

    //    }

    //    private void OnTriggerEnter(Collider other)
    //    {

    //        openCount++;


    //        if (openCount == 1)
    //        {
    //          if (isOpen == false)
    //           {

    //            StartCoroutine(aaa());



    //            }
    //        }
    //        if (openCount > 1)
    //        {

    //        }



    //    }


    //    private void OnTriggerExit(Collider other)
    //    {
    //        openCount++;

    //            StartCoroutine(bbb());


    //    }


    //    public IEnumerator aaa()
    //    {

    //        for (; ; )
    //        {
    //            yield return new WaitForSeconds(0.01f);
    //            transform.position = Vector3.MoveTowards(transform.position, openPos, 20 * Time.deltaTime);
    //            if (isOpen == true)
    //            {
    //                break;

    //            }

    //        }


    //    }


    //    public IEnumerator bbb()
    //    {

    //        for (; ; )
    //        {

    //            yield return new WaitForSeconds(0.1f);
    //            transform.position = Vector3.MoveTowards(transform.position, closePos, 70 * Time.deltaTime);
    //            if (isOpen == true)
    //            {
    //                break;

    //            }

    //        }
    //    }



}
