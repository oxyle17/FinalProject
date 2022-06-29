using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtonScript : MonoBehaviour
{
    [SerializeField] GameObject PauseCanvas;

    public bool pauseMenuIsOpen;
    void Start()
    {
        PauseCanvas.SetActive(false);
    }

    //+
    //+
    //+
    //+
    //+
    //+
    //+NOT
    //    UNUTMA
    //    input escape olcak
    //    ++++++
    //    +
    //    +
    //    +
    //    +
    //    +
    //    +
    //    ++
    //    +


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.P)) && !pauseMenuIsOpen)
        {
            Pausing();
        }
        else if (Input.GetKeyDown(KeyCode.P) && pauseMenuIsOpen)
        {
            Resuming();
        }
    }

    public void Pausing()
    {
        pauseMenuIsOpen = true;
        PauseCanvas.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        gameObject.GetComponent<SC_FPSController>().enabled = false;
        gameObject.GetComponentInChildren<PlayerInteract>().enabled = false;
        gameObject.GetComponent<PlayerAttackScript>().enabled = false;
    }

    public void Resuming()
    {
        pauseMenuIsOpen = false;
        PauseCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        gameObject.GetComponent<SC_FPSController>().enabled = true;
        gameObject.GetComponentInChildren<PlayerInteract>().enabled = true;
        gameObject.GetComponent<PlayerAttackScript>().enabled = true;
    }
}
