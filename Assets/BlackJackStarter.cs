using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJackStarter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Board;
    void Start()
    {
        Player = GameObject.Find("PlayerObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlackJackStart()
    {
        //Player.GetComponent<SC_FPSController>().enabled = false;
        //Player.GetComponent<AttackUI>().enabled = false;
        //Player.GetComponentInChildren<PlayerInteract>().enabled = false;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Board.SetActive(true);
    }
}
