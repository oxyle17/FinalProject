using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    public Transform changeTo;

    public GameObject k�t�phane;
    public GameObject ruinK�t�phane;
    public GameObject dumanlar;

    float count;

    public GameObject women;

    // Start is called before the first frame update
    void Start()
    {

        k�t�phane.SetActive(true);
        ruinK�t�phane.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            if (MagicPower.instance.canExit == true)
            {

                count++;

                if (count == 1)
                {
                    other.transform.position = changeTo.position;
                    k�t�phane.SetActive(false);
                    ruinK�t�phane.SetActive(true);
                    dumanlar.SetActive(false);

                    women.SetActive(false);


                }
                else
                {
                   other.transform.position = changeTo.position;

                   MagicPower.instance.CanFire = false;

                }



            }




            

            




        }





    }

}
