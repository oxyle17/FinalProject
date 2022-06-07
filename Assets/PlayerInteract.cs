using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float distance2See = 5;
    RaycastHit WhatHit;


    public float mice;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * distance2See, Color.magenta);

        if (Physics.Raycast(transform.position, transform.forward, out WhatHit, distance2See))
        {

            Debug.Log(WhatHit.collider.gameObject.name);

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (WhatHit.collider.gameObject.GetComponent<IneractionDome>() != null)
            {
                interactTypes Interacted;
                GameObject InteractedGameObject = WhatHit.collider.gameObject;
                Interacted = InteractedGameObject.GetComponent<IneractionDome>().InteractXD;

                switch (Interacted)
                {
                    case interactTypes.pickup:

                        break;
                    case interactTypes.destroy:
                        Destroy(InteractedGameObject);
                        break;
                    case interactTypes.quest1Start:
                        InteractedGameObject.GetComponent<Quest1Start>().Run2House();
                        break;
                    case interactTypes.mice:
                        Destroy(InteractedGameObject);
                        mice++;
                        break;
                }


            }

        }
    }
}
