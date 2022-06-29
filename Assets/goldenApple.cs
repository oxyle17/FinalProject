using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenApple : MonoBehaviour
{


    public static goldenApple Instance;

    [SerializeField] public GameObject GoldenApple;
    public Transform ApplePoint;




    void Start()
    {
        
        Instance = this;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveApple()
    {


        GoldenApple.transform.forward = ApplePoint.transform.forward;
        GameObject AppleSpawned = Instantiate(GoldenApple, ApplePoint.position, Quaternion.identity);
        AppleSpawned.transform.forward = ApplePoint.transform.forward;


    }


}
