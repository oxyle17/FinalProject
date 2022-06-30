using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NARRATORSCRIPT : MonoBehaviour
{
    public Vector3 RISEPos;
    public bool RISINGBool;
    public bool ROSEBool;
    public float RISESpeed;

    public bool COMBATBool;

    public float timeSinceLastATTACK = 1;
    public float ATTACKInterval = 2;

    [SerializeField] GameObject Player;
    [SerializeField] GameObject NARRATORCANNON;
    [SerializeField] GameObject NARRATORBULLETPREFAB;
    void Start()
    {
        RISEPos = new Vector3(200, 1, 500);
        Invoke(nameof(NARRATORRISE), 6);
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
    }

    public void NARRATORRISE()
    {
        RISINGBool = true;
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

    public void NARRATORRECOVER()
    {

    }
}
