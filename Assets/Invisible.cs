using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{

    public Canvas textC1;
    public Canvas textC2;
    public Canvas textC3;
    public Canvas textC4;

    // Start is called before the first frame update
    void Start()
    {

        textC1.enabled = false;
        textC2.enabled = false;
        textC3.enabled = false;
        textC4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
