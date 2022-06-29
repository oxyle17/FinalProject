using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJackStarter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Board;
    [SerializeField] GameObject PlayerUI;
    [SerializeField] GameObject PlayerCam;
    [SerializeField] GameObject BJCam;
    [SerializeField] GameObject BJCanvas;


    void Start()
    {
        Player = GameObject.Find("PlayerObject");
        Debug.Log("BlackJack");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlackJackStart()
    {
        Player.GetComponent<SC_FPSController>().enabled = false;
        Player.GetComponent<AttackUI>().enabled = false;
        Player.GetComponentInChildren<PlayerInteract>().enabled = false;
        Player.GetComponent<PlayerAttackScript>().enabled = false;
        PlayerUI.SetActive(false);
        PlayerCam.SetActive(false);
        BJCam.SetActive(true);
        BJCanvas.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Board.SetActive(true);
    }
    public void BlackJackEnd()
    {
        Player.GetComponent<SC_FPSController>().enabled = true;
        Player.GetComponent<AttackUI>().enabled = true;
        PlayerCam.GetComponent<PlayerInteract>().enabled = true;
        Player.GetComponent<PlayerAttackScript>().enabled = true;
        PlayerUI.SetActive(true);
        PlayerCam.SetActive(true);
        BJCam.SetActive(false);
        BJCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Board.SetActive(false);
    }
}
