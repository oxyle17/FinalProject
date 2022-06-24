using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombexploded : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject rock;
    public Transform rockTarget;

    public AudioSource expo;

    public float count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (Nazis.instance.Okay == true)
        {

            count++;

            if (count == 1)
            {
 BombButton.instance.bombTimerSound.Stop();
            BombButton.instance.RunCanvas.enabled = false;

            rock.transform.position = rockTarget.position;

            expo.Play();
            }

            if (count > 1)
            {

                Destroy(this);
            }
           



        }



    }

}
