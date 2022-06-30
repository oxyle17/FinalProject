using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sofraVFX : MonoBehaviour
{

    public static sofraVFX instance;

    public ParticleSystem MagicSmoke;

        public AudioSource fx1;
        public AudioSource fx2;



    // ===========================


    public Canvas kingCanvas1;
    public Canvas kingCanvas2;

    public AudioSource kingsound1;
    public AudioSource kingsound2;

    //============================
    //Narrator

    public Canvas bossCanvas;
    public AudioSource bossSound;



    public Canvas narCan1;
    public Canvas narCan2;
    public Canvas narCan3;
    public Canvas narCan4;
    public Canvas narCan5;

    public AudioSource narSon1;
    public AudioSource narSon2;
    public AudioSource narSon3;
    public AudioSource narSon4;
    public AudioSource narSon5;

    //===========================

    //Apple

    public ParticleSystem appleEffect;
    public AudioSource appleEffectSound;
    public AudioSource appleEffectSound2;
    public GameObject apple;


    void Start()
    {

        bossCanvas.enabled = false;

        instance = this;
        apple.GetComponent<MeshRenderer>().enabled = false;


        // ==============================

        kingCanvas1.enabled = false;
        kingCanvas2.enabled = false;

        //============================

        narCan1.enabled = false;
        narCan2.enabled = false;
        narCan3.enabled = false;
        narCan4.enabled = false;
        narCan5.enabled = false;

        // =============================


    }

    // Update is called once per frame
    void Update()
    {
        // ========================================

        if (kingsound1.isPlaying == false)
        {

            kingCanvas1.enabled = false;

        }
        if (kingsound2.isPlaying == false)
        {

            kingCanvas2.enabled = false;

        }

        // ==========================================



        if (narSon1.isPlaying == false)
        {
            narCan1.enabled = false;
        }

        if (narSon2.isPlaying == false)
        {
            narCan2.enabled = false;
        }


        if (narSon3.isPlaying == false)
        {
            narCan3.enabled = false;
        }


        if (narSon4.isPlaying == false) // bossmüzikbasla
        {
            narCan4.enabled = false;
        }


        if (narSon5.isPlaying == false)
        {
            narCan5.enabled = false;
        }

        // =============================================


    }

    void startBoss()
    {


        bossSound.Play();


    }

    void bossCanvasOpen()
    {


        bossCanvas.enabled = true;
    }

    public void getEffect()
    {

        MagicPower.CanFire = false;


        fx1.Play();

        MagicSmoke.Play();

        var cloneSmokeEffect2 = Instantiate(MagicSmoke, transform.position, Quaternion.identity);

        print(cloneSmokeEffect2);

        MagicSmoke.Play();

        fx2.PlayDelayed(1);

        Invoke(nameof(chat), 2);





    }

    void chat()
    {

        speak1();
        Invoke(nameof(speak2), 14);
        Invoke(nameof(speak3), 21);
        Invoke(nameof(openApple), 26);
        Invoke(nameof(speak4), 30);
        Invoke(nameof(speak5), 37);
        Invoke(nameof(speak6), 45);
        Invoke(nameof(startBoss), 43);
        Invoke(nameof(bossCanvasOpen),57);
        Invoke(nameof(speak7), 63); //loadscene
        
    }
        
        


    void openApple()
    {
        appleEffectSound.Play();

        appleEffect.Play();
        var cloneAppleEffect = Instantiate(appleEffect, apple.transform.position, Quaternion.identity);
        print(cloneAppleEffect);

        appleEffect.Play();
        apple.GetComponent<MeshRenderer>().enabled = true;
        appleEffectSound2.PlayDelayed(1);


    }


    void speak1()
    {

        kingCanvas1.enabled = true;
        kingsound1.Play();



    }   // King1

    void speak2()     // Narrator1
    {
        narCan1.enabled = true;
        narSon1.Play();
    }

    void speak3()
    {

        kingCanvas2.enabled = true;
        kingsound2.Play();


    }   // King2Son


    void speak4()      // Narrator2
    {

        narCan2.enabled = true;
        narSon2.Play();

        appleEffectSound2.Stop();
    }


    void speak5()      // Narrator3
    {

        narCan3.enabled = true;
        narSon3.Play();

        Invoke(nameof(closeApple), 4);
        
    }


    void speak6()      // Narrator4
    {

        narCan4.enabled = true;
        narSon4.Play();


    }


    void speak7()      // Narrator5
    {

        SceneManager.LoadScene(4);

    }

    
   public void closeApple()
    {

        appleEffectSound2.Stop();


    }


}
