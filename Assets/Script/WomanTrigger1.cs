using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanTrigger1 : MonoBehaviour
{
    [SerializeField] Canvas w1;
    [SerializeField] AudioSource ws1;
    [SerializeField] Canvas questionMark;

    void Start()
    {
        questionMark.enabled = false;
        w1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ws1.isPlaying == false)
        {

            w1.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {



        ws1.Play();
        w1.enabled = true;
        questionMark.enabled = true;


    }
    private void OnTriggerExit(Collider other)
    {
        questionMark.enabled = false;

        gameObject.GetComponent<BoxCollider>().enabled = false;


    }


}
