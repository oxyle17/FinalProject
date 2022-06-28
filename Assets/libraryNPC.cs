using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class libraryNPC : MonoBehaviour
{

    public static libraryNPC instance;

    public GameObject npc;


    [SerializeField] Canvas npc1;
    [SerializeField] Canvas npc2;
    [SerializeField] Canvas npc3;

    [SerializeField] AudioSource sound1;
    [SerializeField] AudioSource sound2;
    [SerializeField] AudioSource sound3;



   


    void Start()
    {
        instance = this;


        npc1.enabled = false;
        npc2.enabled = false;
        npc3.enabled = false;


        npc.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (sound1.isPlaying == false)
        {

            npc1.enabled = false;

        }
        if (sound2.isPlaying == false)
        {

            npc2.enabled = false;

        }
        if (sound3.isPlaying == false)
        {

            npc3.enabled = false;

        }





        if (epicbook.instante.openNpc == true)
        {


            npc.SetActive(true);
        }




    }

   public void speaking()
    {

        a1();
        Invoke(nameof(a2), 3);
        Invoke(nameof(a3), 8);

        Invoke(nameof(openBook), 11);


    }

    void a1()
    {
        npc1.enabled = true;
        sound1.Play();

    }

    void a2()
    {
        npc2.enabled = true;
        sound2.Play();
    }

    void a3()
    {
        npc3.enabled = true;
        sound3.Play();
    }

    
    public void openBook()
    {

        MagicPower.instance.gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.MagicBook;

    }

}

