using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

   


    public static PlayerInteract instance;
    public float checkFloat;
    public float distance2See = 1;
    RaycastHit WhatHit;

    public Transform changeTo;
    public bool AllMiceCollect = false;

    // Fade Out - In     -Kaan

    public AnimationCurve FadeCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(1, 0));

    private float _alpha = 3;
    private Texture2D _texture;
    public bool _done;
    private float _time;

    // Fade Out - In       - Kaan

    public void Reset()
    {
        _done = false;
        _alpha = 3;
        _time = 0;
    }   // Kaan

    [RuntimeInitializeOnLoadMethod] // Kaan
    public void RedoFade()
    {
        Reset();
    }      // Kaan
    public void OnGUI()
    {
        if (_done) return;
        if (_texture == null) _texture = new Texture2D(1, 1);

        _texture.SetPixel(0, 0, new Color(0, 0, 0, _alpha));
        _texture.Apply();

        _time += Time.deltaTime;
        _alpha = FadeCurve.Evaluate(_time);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _texture);

        if (_alpha <= 0) _done = true;
    }        // Kaan


    public float mice;  

    void Start()
    {

        Debug.Log("PlayerInteract");

        _done = true;  // Kaan

        InvokeRepeating(nameof(checkMice), 1, 1);   // Kaan

        instance = this; // Kaan

    }

    // Update is called once per frame
    void Update()
    {




        Debug.DrawRay(transform.position, transform.forward * distance2See, Color.magenta);

        if (Physics.Raycast(transform.position, transform.forward, out WhatHit, distance2See))
        {

            Debug.Log(WhatHit.collider.gameObject.name);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {

           

            if (WhatHit.collider.gameObject.GetComponent<IneractionDome>() != null)
            {
                interactTypes Interacted;
                GameObject InteractedGameObject = WhatHit.collider.gameObject;
                Interacted = InteractedGameObject.GetComponent<IneractionDome>().InteractXD;

                switch (Interacted)
                {
                    case interactTypes.pickup:

                        break;
                    case interactTypes.destroy:
                        Destroy(InteractedGameObject);
                        break;
                    case interactTypes.quest1Start:
                        InteractedGameObject.GetComponent<Quest1Start>().Run2House();
                        break;
                    case interactTypes.mice:
                        Destroy(InteractedGameObject);
                        mice++;
                        break;
                    case interactTypes.quest1Fin:
                        if (mice == 9)
                        {
                            InteractedGameObject.GetComponent<Quest1Fin>().Quest1End();
                        }
                        break;
                    case interactTypes.quest2Start:
                        InteractedGameObject.GetComponent<BlackJackStarter>().BlackJackStart();
                        break;
                }


            }

        }
    }


   
    public void AraSahne1()
    {

        if (AllMiceCollect == true)
        {
            AraSahen.instance.quest1Music.Stop();

            AraSahen.instance.Sahne1();


           
        }




    }     // Kaan

   
    public void checkMice()
    {


        if (mice == 9)
        {
            checkFloat++;
                



            AllMiceCollect = true;

            if (checkFloat == 1)
            {

              AraSahne1();
            }
            if (checkFloat > 1)
            {

                CancelInvoke(nameof(checkMice));

            }
           


        }


    }     // Kaan

}
