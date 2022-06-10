using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1Fin : MonoBehaviour
    
{
    // Start is called before the first frame update
    [SerializeField]GameObject Player;
    [SerializeField] GameObject TeleDes;
    void Start()
    {
        Player = GameObject.Find("PlayerObject");
        TeleDes = GameObject.Find("Quest1NPCDesination");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quest1End()
    {
        Player.transform.position = TeleDes.transform.position;

    }
}
