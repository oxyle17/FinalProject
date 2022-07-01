using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanScript : MonoBehaviour
{

    public static CanScript instance;

    [SerializeField] float PlayerHealth = 3;
    [SerializeField] Canvas Hearth1;
    [SerializeField] Canvas Hearth2;
    

    [SerializeField] Canvas DeadCanvas;

    public  float count;

    void Start()
    {
        instance = this;

        Hearth1.enabled = false;
        Hearth2.enabled = false;
       
        DeadCanvas.enabled = false;



    }

    // Update is called once per frame
    void Update()
    {
        


    }


   public  void canAzal()
    {
        count++;

        if (count == 1)
        {
            Hearth1.enabled = true;
            

        }
        if (count == 2)
        {

            Hearth2.enabled = true;
        }
        if (count == 3)
        {
            DeadCanvas.enabled = true;
        }



    }





   

}
