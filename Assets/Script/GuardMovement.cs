using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    Vector3 TargetPos;

    [SerializeField] Canvas VisaUI;
    [SerializeField] Canvas currentUI;

    [SerializeField] Canvas G1;
    [SerializeField] Canvas G2;
    [SerializeField] Canvas N1;
    [SerializeField] Canvas TutorialCanvas;

    [SerializeField] AudioSource GS1;
    [SerializeField] AudioSource GS2;
    [SerializeField] AudioSource N;



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

        g1();
        Invoke(nameof(nar), 5);
        Invoke(nameof(UIchange), 15);

        

       


    }

    public IEnumerator aaa()
    {

        for (; ; )
        {
            yield return new WaitForSeconds(0.1f);
            transform.position = Vector3.MoveTowards(transform.position, TargetPos, 50 * Time.deltaTime);
           




        }


    }


    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
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

        StartCoroutine(aaa());


    }
    public void pass()
    {


        TutorialCanvas.enabled = false;

        VisaUI.enabled = false;
        currentUI.enabled = true;


            g2();
            Invoke(nameof(GuardMov), 6);





    }

}