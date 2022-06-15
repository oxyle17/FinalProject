using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1Fin : MonoBehaviour
    
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player;
    [SerializeField] GameObject TeleDes;
    [SerializeField] GameObject RB1;
    void Start()
    {
        Debug.Log("QuetFind1");

        Player = GameObject.Find("PlayerObject");
        TeleDes = GameObject.Find("Quest1NPCDesination");
        RB1 = GameObject.Find("RoadBlock1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quest1End()
    {
        Player.transform.position = TeleDes.transform.position;
        Destroy(RB1);
    }
}
