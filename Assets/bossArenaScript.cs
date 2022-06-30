using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossArenaScript : MonoBehaviour
{
    [SerializeField] Canvas narratorCanvas;
    [SerializeField] Canvas BlackScreen;
    [SerializeField] Canvas Hands;

    [SerializeField] AudioSource bossmusic;
    [SerializeField] AudioSource narratorSound;
 
    void Start()
    {
        Hands.enabled = false;
        MagicPower.CanFire = true;
        narratorCanvas.enabled = false;
        BlackScreen.enabled = true;
        bossArena();
    }

    // Update is called once per frame
    void Update()
    {

        if (narratorSound.isPlaying == false)
        {
            narratorCanvas.enabled = false;

        }
        
    }

    void bossArena()
    {



        bossmusic.Play();

        Invoke(nameof(openScreen), 1.3f);
        Invoke(nameof(OpenMyHand), 1.3f);

        Invoke(nameof(narSon), 3);




    }


    void openScreen()
    {


        BlackScreen.enabled = false;

        narratorCanvas.enabled = true;

    }


    void narSon()
    {
        narratorCanvas.enabled = true;
        narratorSound.Play();
      
        



    }

    void OpenMyHand()
    {

        Hands.enabled = true;


    }
}
