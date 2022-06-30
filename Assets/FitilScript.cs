using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitilScript : MonoBehaviour
{
    public bool JustFired;
    [SerializeField] GameObject NARRATOR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FireBall"))
        {
            JustFired = true;
            FireCannon();

        }
    }
    public void FireCannon()
    {
        //Kaan buraya ateş sesi
        NARRATOR.GetComponent<NARRATORSCRIPT>().Cannonned();
        
    }
}
