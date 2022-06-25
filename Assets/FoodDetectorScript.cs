using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDetectorScript : MonoBehaviour
{
    public float foodCounter;
    public GameObject[] foodObjects;
    public bool cookable;

    void Start()
    {
        foodObjects = GameObject.FindGameObjectsWithTag("Food");
    }

    // Update is called once per frame
    void Update()
    {
        if (foodCounter > 10) cookable = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            foodCounter++;
        }
        else if (other.CompareTag("FireBall") && cookable)
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
        foreach (GameObject foodObject in foodObjects)
        {
            Destroy(foodObject);
        }

    }
}
