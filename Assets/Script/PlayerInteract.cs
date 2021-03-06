using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{

    public GameObject tahtalar;
    public GameObject duvar;

    public LayerMask bes;

    public static PlayerInteract instance;
    public float checkFloat;
    public float distance2See = 1;
    RaycastHit WhatHit;
    [SerializeField] GameObject ActiveCrosshair;

    public Transform changeTo;
    public bool AllMiceCollect = false;
    public float checkMices;
    public float checkMices2;

    public bool okeyCount = false;

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
    public float totalMice = 10;

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

        Ray rey = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(transform.position, transform.forward, out WhatHit, distance2See, bes, QueryTriggerInteraction.Ignore))
        {

            Debug.Log(WhatHit.collider.gameObject.name);

        }
        if (WhatHit.collider == null)
        {
            ActiveCrosshair.GetComponent<Image>().enabled = false;
        }
        else if (WhatHit.collider.gameObject.GetComponent<IneractionDome>() == null)
        {
            ActiveCrosshair.GetComponent<Image>().enabled = false;
        }
        else if (WhatHit.collider.gameObject.GetComponent<IneractionDome>().InteractXD != interactTypes.numb)
        {
            ActiveCrosshair.GetComponent<Image>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (WhatHit.collider == null)
            {
                return;
            }
            if (WhatHit.collider.gameObject.GetComponent<IneractionDome>() != null)
            {
                interactTypes Interacted;
                GameObject InteractedGameObject = WhatHit.collider.gameObject;
                Interacted = InteractedGameObject.GetComponent<IneractionDome>().InteractXD;

                switch (Interacted)
                {
                    case interactTypes.pickup:
                        InteractedGameObject.GetComponent<Pickup>().PickingUp();
                        break;
                    case interactTypes.destroy:
                        Destroy(InteractedGameObject);
                        break;
                    case interactTypes.quest1Start:

                        InteractedGameObject.GetComponent<Quest1Start>().Run2House();
                        WomanTrigger2.instance.isAcceptQuest = true;
                        break;
                    case interactTypes.mice:

                        void StartVfx()
                        {

                            SesKaynak.instance.miceVFX.Play();
                            var cloneMiceVFX = Instantiate(SesKaynak.instance.miceVFX, InteractedGameObject.transform.position, Quaternion.identity);
                            print(cloneMiceVFX);

                            SesKaynak.instance.miceVFX.Play();
                        }



                        StartVfx();
                        SesKaynak.instance.Anan1();
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
                    case interactTypes.visaGuard:
                        if (!WhatHit.collider.isTrigger && InteractedGameObject.GetComponent<GuardMovement>() != null)
                        {
                            InteractedGameObject.GetComponent<GuardMovement>().pass();
                        }
                        break;

                    case interactTypes.bombButton:

                        InteractedGameObject.GetComponent<BombButton>().bombaciM?layim();

                            break;

                    case interactTypes.MagicBook:
                         InteractedGameObject.GetComponent<MagicPower>().keepBook();
                        break;
                    case interactTypes.numb:
                        
                        break;

                    case interactTypes.epicBook:

                        InteractedGameObject.GetComponent<epicbook>().KeepEpicBook();


                        break;


                    case interactTypes.endDoor:

                        InteractedGameObject.GetComponent<sonGapiScript>().OpenEndDoor();

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
            checkMices++;

            if (checkMices == 1)
            {
              
            }
            
            
           

        }


        if (mice == 10)
        {
            checkMices2++;

            if (checkMices2 == 1)
            {
               AraSahen.instance.AnlaticiTalk2();
            }
            

        }



        if (mice == 14)
        {

            okeyCount = true;

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
