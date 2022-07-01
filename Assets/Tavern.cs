using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    public Transform changeTo;

    public GameObject kütüphane;
    public GameObject ruinKütüphane;
    public GameObject dumanlar;

    float count;

   

    // Start is called before the first frame update
    void Start()
    {

        kütüphane.SetActive(true);
        ruinKütüphane.SetActive(false);

       

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
                MagicPower.CanFire = false;

                count++;

                if (count == 1)
                {
                    other.transform.position = changeTo.position;
                    kütüphane.SetActive(false);
                    ruinKütüphane.SetActive(true);
                    dumanlar.SetActive(false);

                    MagicPower.CanFire = false; // tavernaya girdiginde kapatma
                  


                }
                else
                {
                   other.transform.position = changeTo.position;

                   MagicPower.CanFire = false; // tavernaya girme

                }



            }




            

            




        }





    }

}
