using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCounterScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int count;

    void Start()
    {
        count = Camera.allCameras.Length;
        Debug.LogError("We've got " + count + " cameras");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
