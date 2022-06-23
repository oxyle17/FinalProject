using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookscene : MonoBehaviour
{

    public Light cinematicLight;

    [SerializeField] AudioSource lacrimosa;


    void Start()
    {

        cinematicLight.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        lacrimosa.Play();

        Invoke(nameof(openLight), 11.3f);

    }


    void openLight()
    {

        cinematicLight.enabled = true;

    }

}
