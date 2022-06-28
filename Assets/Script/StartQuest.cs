using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StartQuest : MonoBehaviour
{
    public static StartQuest instance;

    public Transform changeTo;

    [SerializeField] Canvas a1;

    public TextMeshProUGUI miceCounter;

    public bool enter=false;
    public float count;

    void Start()
    {
        Debug.Log("StartQuest1");
        a1.enabled = false;

        miceCounter.enabled = false;
        instance = this;

    }

   

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            a1.enabled = false;


        }


        if (PlayerInteract.instance.mice <= 9)
        {
          miceCounter.text = PlayerInteract.instance.totalMice.ToString() + " / " + PlayerInteract.instance.mice.ToString();
        }
        if (PlayerInteract.instance.mice > 9)
        {

            if (PlayerInteract.instance.okeyCount == true)
            {


                miceCounter.text = PlayerInteract.instance.totalMice.ToString() + " / " + PlayerInteract.instance.totalMice.ToString();


            }


        }
       



    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            count++;

            if (count == 1)
            {

               

                if (WomanTrigger2.instance.isAcceptQuest == true)
                {

                    enter = true;

                    miceCounter.enabled = true; 
                    other.transform.position = changeTo.position;

                    a1.enabled = true;



                }





            }
            if (count > 1)
            {

            }
           
           
           




        }





    }

}
