using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButton : MonoBehaviour
{

    public static BombButton instance;

    public AudioSource bombTimerSound;

   

    public float clickCount;

    public Canvas RunCanvas;


    void Start()
    {
        instance = this;

        RunCanvas.enabled = false;

    }

    void Update()
    {
        
    }

    public void bombaciMülayim()
    {

        clickCount++;

        if (clickCount == 1)
        {
           bombTimerSound.Play();


            gameObject.GetComponentInParent<IneractionDome>().InteractXD = interactTypes.numb;

            Invoke(nameof(openCanvas), 3);

        }

       









    }


    void openCanvas()
    {

        RunCanvas.enabled = true;

    }


}
