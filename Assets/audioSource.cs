using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourcee : MonoBehaviour
{
    [SerializeField] AudioSource denem1;


    public static AudioSourcee instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aabb()
    {



        denem1.Play();

    }

}
