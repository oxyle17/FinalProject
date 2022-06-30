using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioSource source;

    private void Start()
    {
        source.Play();
    }


    public void startGameButton()
    {
        source.Stop();

        SceneManager.LoadScene(2);


    }


    
}
