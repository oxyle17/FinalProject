using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDetectorScript : MonoBehaviour
{


    public static FoodDetectorScript instance;

    public float foodCounter;
    public GameObject[] foodObjects;
    public bool cookable;


    public GameObject sofra;
    public Transform sofraTarget;


   

   



    void Start()
    {
        instance = this;

        foodObjects = GameObject.FindGameObjectsWithTag("Food");
    }

    // Update is called once per frame
    void Update()
    {
        if (foodCounter >= 5) cookable = true;

        if (cookable == true)
        {

            MagicPower.CanFire = true;


        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            foodCounter++;
        }
         if (other.CompareTag("FireBall") && cookable)
        {
            Cook();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            foodCounter--;
        }
    }
    public void Cook()
    {
        //diyalog fln

         KingTrigger.instance.missionSound.Stop();

         sofraVFX.instance.getEffect();


        foreach (GameObject foodObject in foodObjects)
        {
             Destroy(foodObject);

           

        }

       
         teleportSofra();

    }

    public void teleportSofra()
    {

        sofra.transform.position = sofraTarget.position;



    }


   

    


}
