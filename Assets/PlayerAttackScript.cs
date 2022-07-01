using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttackScript : MonoBehaviour
{
    public static PlayerAttackScript instance;

    [SerializeField] public GameObject FireBall;

    public Transform FirePoint;
    public Camera Cam;
    public float maxhealth = 100;
    public float currenthealth = 100;

    public Canvas attackUI;
    public Canvas defaultUICanvas;


    [SerializeField] Slider PlayerHealthBar;
   


    public GameObject canvaslar;

    public GameObject playerHealthCanvas;
    public GameObject bossHealthCanvas;

    // =========
    // Cooldown



    public float timeSetFire;
    public float FireInterval = 2;

    public AudioSource fireballAudio;

    void Start()
    {
        instance = this;

        attackUI.enabled = false;

        if (bossArenaScript.CanOpen == true) // city scene
        {
            CityCanvas();
            
        }


        if (bossArenaScript.CanOpen == false) // boss
        {
           /*
          playerHealthCanvas.SetActive(false);
          bossHealthCanvas.SetActive(false);
            */

          Invoke(nameof(loadBars), 25);


        }

       


          PlayerHealthBar.value = currenthealth;
          PlayerHealthBar.maxValue = maxhealth;



    }
    
   public void loadBars()
    {
        if (bossArenaScript.CanOpen == false)
        {
          playerHealthCanvas.SetActive(true);
          bossHealthCanvas.SetActive(true);

        }

       

    }



    public void dokunma()
    {

        playerHealthCanvas.SetActive(true);
        bossHealthCanvas.SetActive(true);




    }


    void Update()
    {

        timeSetFire += Time.deltaTime;

        PlayerHealthBar.value = currenthealth;

        if (Input.GetKeyDown(KeyCode.Mouse0) && timeSetFire > FireInterval)
        {
            if (MagicPower.CanFire == true) // ates etme icin
            {

                attackUI.enabled = true;

                defaultUICanvas.enabled = false;


              Fire();
            }
        }
    }


    public void CityCanvas()
    {

        canvaslar.SetActive(false);
        playerHealthCanvas.SetActive(false);
        bossHealthCanvas.SetActive(false);


    }

    public void Fire()
    {
        timeSetFire = 0;

        fireballAudio.Play();

        FireBall.transform.forward = FirePoint.transform.forward;
        GameObject bulletSpawned = Instantiate(FireBall, FirePoint.position, Quaternion.identity);
        bulletSpawned.transform.forward = FirePoint.transform.forward;

       
        Invoke(nameof(handsFree), 1);

    }


    public void handsFree()
    {
        attackUI.enabled = false;
        defaultUICanvas.enabled = true;

    }

    public void TakeDamage()
    {
        currenthealth--;
        PlayerHealthBar.value = currenthealth;
        if (currenthealth <= 0)
        {
            Death();

        }
    }


    public void Death()
    {



        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        SceneManager.LoadScene(6);



    

       
    }


   
}
