using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public GameObject barrel;
    public GameObject fitil;

    public Canvas ReadyCanvas;
    public Canvas ReloadCanvas;

    void Start()
    {
        fitil.GetComponent<BoxCollider>().enabled = false;
        ReadyCanvas.enabled = false;

        ReloadCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (barrel.GetComponent<BarrelScript>().CannonFireable)
        {
            ReloadCanvas.enabled = false;
            ReadyCanvas.enabled = true;

            fitil.GetComponent<BoxCollider>().enabled = true;
            barrel.GetComponent<BoxCollider>().enabled = false;
        }
        if(barrel.GetComponent<BarrelScript>().CannonFireable == false)
        {
            fitil.GetComponent<BoxCollider>().enabled = false;
            barrel.GetComponent<BoxCollider>().enabled = true;
        }

        if (fitil.GetComponent<FitilScript>().JustFired)
        {
            ReloadCanvas.enabled = true;
            ReadyCanvas.enabled = false;

            Reload();
        }
    }

    public void Reload()
    {
        fitil.GetComponent<FitilScript>().JustFired = false;
        barrel.GetComponent<BarrelScript>().CannonFireable = false;
    }
}
