using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossArenaScript : MonoBehaviour
{

    public static bossArenaScript Instance;

    [SerializeField] Canvas narratorCanvas;
    [SerializeField] Canvas BlackScreen;
    [SerializeField] Canvas Hands;

    public AudioSource bossmusic;
    [SerializeField] AudioSource narratorSound;
    [SerializeField] AudioSource bossDeathSound;

    public static bool CanOpen = false;

   
    
 
    void Start()
    {

        PlayerAttackScript.instance.canvaslar.SetActive(true);

      
            Invoke(nameof(PlayerAttackScript.instance.dokunma), 25);


        Instance = this;
        Hands.enabled = false;

        MagicPower.CanFire = true; // boss arena baslangic

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

   public void BossDeath()
    {

        bossDeathSound.Play();
        Invoke(nameof(closeMusic), 3);

    }

    void closeMusic()
    {

        bossmusic.Stop();

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
