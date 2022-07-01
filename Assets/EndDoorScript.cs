using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDoorScript : MonoBehaviour
{

    public static EndDoorScript instance;

    public AudioSource doorSound;
    [SerializeField] GameObject plotRoom;
    public GameObject roomLight;

    [SerializeField] ParticleSystem RoomSpawnEffect;
    [SerializeField] AudioSource SpawnEffectFX;

    [SerializeField] GameObject Door;

   public Transform vfxPoint;
    
    
    void Start()
    {



        instance = this;

        plotRoom.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {


      
    }

    void GetEffect()
    {

        SpawnEffectFX.Play();

        RoomSpawnEffect.Play();

        var cloneRoomSpawnEffect = Instantiate(RoomSpawnEffect, vfxPoint.transform.position, Quaternion.identity);
        print(cloneRoomSpawnEffect);

        RoomSpawnEffect.Play();
      

        



    }

    public void IfbossDead()
    {
        Invoke(nameof(gecikmeli), 7);


    }

    void gecikmeli()
    {
        NARRATORSCRIPT.instance.effect.SetActive(false);
        GetEffect();
        plotRoom.SetActive(true);

        roomLight.SetActive(false);

    }
  

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {


            SceneManager.LoadScene(5);



        }


    }



}
