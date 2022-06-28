using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class epicbook : MonoBehaviour
{
    // Start is called before the first frame update

    public static epicbook instante;
    public bool Openexit = false;
    public bool openNpc = false;
    void Start()
    {

        instante = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void KeepEpicBook()
    {

        if (bookscene.instante.open == true)
        {
            openNpc = true;

            bookscene.instante.cinematicLight.enabled = false;
            bookscene.instante.lacrimosa.Stop();

            libraryNPC.instance.speaking();


            gameObject.GetComponentInParent<IneractionDome>().InteractXD = interactTypes.numb;

            


           

        }


          





    }

}
