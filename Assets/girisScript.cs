using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class girisScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



        Invoke(nameof(loadMenu), 8);

    }

    void loadMenu()
    {

        SceneManager.LoadScene(1);


    }
   
}
