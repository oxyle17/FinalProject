using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NARRATORSCRIPT : MonoBehaviour
{

    public static NARRATORSCRIPT instance;

    public Vector3 RISEPos;
    public bool RISINGBool;
    public bool ROSEBool;
    public float RISESpeed;

    public bool COMBATBool;

    public GameObject healthBarObj;
    public Slider healthBar;

    public GameObject playerHealthBar;



    public float currentHealth;
    public float maxHealth = 10;

    public GameObject Player;
    [SerializeField] GameObject NARRATORCANNON;
    [SerializeField] GameObject NARRATORBULLETPREFAB;

    public float timeSinceLastATTACK;
    public float ATTACKInterval;

    public GameObject effect;
   


    void Start()
    {

        Invoke(nameof(BarEnable), 10); //
        Invoke(nameof(PlayerCanvasEnable), 2);

        Invoke(nameof(riseModel), 12);
        instance = this;
        Invoke(nameof(NARRATORRISE), 12);

        effect.SetActive(false);
        
        healthBar = healthBarObj.GetComponentInChildren<Slider>();

        currentHealth = maxHealth;
        healthBar.value = currentHealth;
        healthBar.maxValue = maxHealth;
    }

    public void PlayerCanvasEnable()
    {
        Player.GetComponent<PlayerAttackScript>().canvaslar.SetActive(true);
    }

    void BarEnable()
    {

        healthBarObj.gameObject.SetActive(true);
        playerHealthBar.gameObject.SetActive(true);





    }


    void riseModel()
    {

        RISEPos = new Vector3(250, 30, 500);

    }

    //250


    void Update()
    {

      

        if (RISINGBool)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position ,RISEPos, RISESpeed * Time.deltaTime);
        }

        if (gameObject.transform.position == RISEPos)
        {
            RISINGBool = false;
            ROSEBool = true;
        }

        if (ROSEBool)
        {
            //Animasyon
            Invoke(nameof(NARRATORCOMBATSTART), 1f);
        }

        if (COMBATBool)
        {
            timeSinceLastATTACK += Time.deltaTime;

            if (timeSinceLastATTACK >= ATTACKInterval)
            {
                NARRATORATTACK();
            }
        }
        
        if (currentHealth <= 0)
        {

            end();
            


        }
    }

    public void NARRATORRISE()
    {
        RISINGBool = true;
        healthBar.value = currentHealth;
    }

    public void NARRATORCOMBATSTART()
    {
        COMBATBool = true;
    }

    public void NARRATORATTACK()
    {
        timeSinceLastATTACK = 0;

        GameObject bulletSpawned = Instantiate(NARRATORBULLETPREFAB, NARRATORCANNON.transform.position, Quaternion.identity);
    }

    public void NARRATORSTUN()
    {

    }

    public void Cannonned()
    {
        currentHealth -= 40;
        healthBar.value = currentHealth;
    }

    public void NARRATORRECOVER()
    {

    }

    public void end()
    {
        PlayerAttackScript.instance.playerHealthCanvas.SetActive(false);
        PlayerAttackScript.instance.playerHealthCanvas.SetActive(false);
        PlayerAttackScript.instance.bossHealthCanvas.SetActive(false);




        bossArenaScript.Instance.BossDeath();

        EndDoorScript.instance.IfbossDead();


         Invoke(nameof(openEffect), 1.3f);
         Destroy(gameObject,3f);

    }

    void openEffect()
    {
        effect.SetActive(true);



    }

    public void spawnRoom()
    {

        EndDoorScript.instance.IfbossDead();


    }

    public void endAgain()
    {
        Destroy(gameObject);

        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FireBall"))
        {
            currentHealth -= 5;
            healthBar.value = currentHealth;
        }
    }
}
