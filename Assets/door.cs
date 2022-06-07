using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    Vector3 openPos;
    Vector3 closePos;

    bool isOpen = false;

    public int openCount;


    void Start()
    {


        closePos = transform.position;

        openPos = transform.position;
        openPos.z += 16;




    }

    public void Open()
    {


        isOpen = true;




    }




    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        openCount++;


        if (openCount == 1)
        {
          if (isOpen == false)
           {

            StartCoroutine(aaa());



            }
        }
        if (openCount > 1)
        {

        }
        
       

    }


    private void OnTriggerExit(Collider other)
    {
        openCount++;
       
            StartCoroutine(bbb());
       

    }


    public IEnumerator aaa()
    {

        for (; ; )
        {
            yield return new WaitForSeconds(0.1f);
            transform.position = Vector3.MoveTowards(transform.position, openPos, 40 * Time.deltaTime);
            if (isOpen == true)
            {
                break;

            }

        }
        
        
    }


    public IEnumerator bbb()
    {

        for (; ; )
        {

            yield return new WaitForSeconds(0.1f);
            transform.position = Vector3.MoveTowards(transform.position, closePos, 40 * Time.deltaTime);
            if (isOpen == true)
            {
                break;

            }

        }
    }



}
