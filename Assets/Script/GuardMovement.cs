using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GuardMovement : MonoBehaviour
{
    Vector3 TargetPos;




    [SerializeField] Canvas VisaUI;
    [SerializeField] Canvas currentUI;

    [SerializeField] Canvas G1;
    [SerializeField] Canvas G2;
    [SerializeField] Canvas N1;
    [SerializeField] Canvas TutorialCanvas;
    [SerializeField] GameObject LookRig;

    [SerializeField] AudioSource GS1;
    [SerializeField] AudioSource GS2;
    [SerializeField] AudioSource N;

    [SerializeField] GameObject door1;
    [SerializeField] GameObject door2;




    public bool isArrive = false;
    public bool VisaGave = false;
    public bool CanPass = false;


    void Start()
    {
        

        Debug.Log("GuardMovement");

        TutorialCanvas.enabled = false;

        VisaUI.enabled = false;
        currentUI.enabled = true;
        N1.enabled = false;
        G1.enabled = false;
        G2.enabled = false;

        LookRig.SetActive(false);


        TargetPos = transform.position;
        TargetPos.z += 9;
    }

    // Update is called once per frame
    void Update()
    {

        if (GS1.isPlaying == false)
        {

            G1.enabled = false;
        }

        if (GS2.isPlaying == false)
        {

            G2.enabled = false;
        }

        if (N.isPlaying == false)
        {

            N1.enabled = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.CompareTag("Player"))
        {
            g1();
            Invoke(nameof(nar), 5);


            Invoke(nameof(haha), 15);
            Invoke(nameof(OpenInteract), 15.2f);
            //* elimizde

            Invoke(nameof(UIchange), 15.03f);


            LookRig.SetActive(true);
        }


    }




    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            LookRig.SetActive(false);

            Destroy(this);
        }

    }

    private void g1()
    {

        GS1.Play();
        G1.enabled = true;

    }

    private void g2()
    {

        GS2.Play();
        G2.enabled = true;

    }

    private void nar()
    {

        N.Play();
        N1.enabled = true;

    }

    private void UIchange()
    {

        currentUI.enabled = false;
        VisaUI.enabled = true;
        TutorialCanvas.enabled = true;


    }
    private void GuardMov()
    {

        door1.GetComponent<RotateDoorScript>().Door1OpenTrigger();
        door2.GetComponent<RotateDoorScript2>().Door1OpenTrigger();


        //door.instance.openDoor();







    }
    public void pass()
    {

        haha();

        TutorialCanvas.enabled = false;
        gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.numb;

        VisaUI.enabled = false;
        currentUI.enabled = true;


            g2();
            Invoke(nameof(GuardMov), 5);





    }


   public void haha()
    {

        Efectt.instance.openSmoke();


    }


      public void OpenInteract()
    {


        gameObject.GetComponent<IneractionDome>().InteractXD = interactTypes.visaGuard;


    }

}