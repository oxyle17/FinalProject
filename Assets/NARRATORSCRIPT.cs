using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NARRATORSCRIPT : MonoBehaviour
{
    public Vector3 RISEPos;
    public bool RISINGBool;
    public bool ROSEBool;
    public float RISESpeed;

    public bool COMBATBool;

    public GameObject healthBarObj;
    public Slider healthBar;
    public float currentHealth;
    public float maxHealth = 100;

    [SerializeField] GameObject Player;
    [SerializeField] GameObject NARRATORCANNON;
    [SerializeField] GameObject NARRATORBULLETPREFAB;

    public float timeSinceLastATTACK;
    public float ATTACKInterval;

    void Start()
    {
        RISEPos = new Vector3(200, 75, 500);
        
        Invoke(nameof(NARRATORRISE), 6);

        healthBar = healthBarObj.GetComponentInChildren<Slider>();
        currentHealth = maxHealth;
        healthBar.value = currentHealth;
        healthBar.maxValue = maxHealth;
    }

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
            Invoke(nameof(NARRATORCOMBATSTART), 4);
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
        currentHealth -= 20;
        healthBar.value = currentHealth;
    }

    public void NARRATORRECOVER()
    {

    }

    public void end()
    {

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
