using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AraSahen : MonoBehaviour
{
    public static AraSahen instance;

    public ParticleSystem doorVFX;

    [SerializeField] AudioSource duvarYikim;

    [SerializeField] AudioSource fareA1;
    [SerializeField] AudioSource fareA2;
    [SerializeField] AudioSource fareA3;
    [SerializeField] AudioSource fareA4;

    [SerializeField] Canvas FareAC1;
    [SerializeField] Canvas FareAC2;
    [SerializeField] Canvas FareAC3;
    [SerializeField] Canvas FareAC4;

    public AudioSource quest1Music;
    public GameObject Player;

   

   

    
    void Start()
    {


        Debug.Log("AraSahen");
       
        instance = this;

        FareAC1.enabled = false;
        FareAC2.enabled = false;
        FareAC3.enabled = false;
        FareAC4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (fareA1.isPlaying == false)
        {

            FareAC1.enabled = false;

        }

        if (fareA2.isPlaying == false)
        {

            FareAC2.enabled = false;
        }

        if (fareA3.isPlaying == false)
        {


            FareAC3.enabled = false;      
        }
        if (fareA4.isPlaying == false)
        {

            FareAC4.enabled = false;

        }



    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Quest1"))
        {
            if (WomanTrigger2.instance.isAcceptQuest == true)
            {
quest1Music.Play();
            }

            


        }

    }

    public void Sahne1()
    {
        duvarYikim.Play();

        Invoke(nameof(doorDestroy), 2);


        Invoke(nameof(meshClose), 3);




        Invoke(nameof(AnlaticiTalk3), 4);

        Invoke(nameof(AnlaticiTalk4), 22);

        Invoke(nameof(destroyWall), 23);



    }


    public void fadeOut()
    {
        PlayerInteract.instance._done = true;
    }

    public void FadeIn()
    {

        PlayerInteract.instance._done = false;

    }


    public void destroyWall()
    {

        Destroy(PlayerInteract.instance.duvar);

    }


    public void AnlaticiTalk1()
    {
        FareAC1.enabled = true;
       fareA1.Play();



    }
    public void AnlaticiTalk2()
    {
        FareAC2.enabled = true;
        fareA2.Play();

    }

   public void AnlaticiTalk3()
    {
        FareAC3.enabled = true;
        fareA3.Play();

    }

    public void AnlaticiTalk4()
    {
        FareAC4.enabled = true;
        fareA4.Play();

    }



    public void doorDestroy()
    {


        doorVFX.Play();

        var clonedoorVFX = Instantiate(doorVFX, PlayerInteract.instance.duvar.transform.position, Quaternion.identity);
        print(clonedoorVFX);

        doorVFX.Play();





    }

    public void meshClose()
    {

        PlayerInteract.instance.duvar.GetComponent<MeshRenderer>().enabled = false;


    }

}
