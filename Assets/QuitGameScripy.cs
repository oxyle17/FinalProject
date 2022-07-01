using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScripy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(quitGame), 51);
        
    }


    void quitGame()
    {


        Application.Quit();


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
