using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum interactTypes
{
    pickup, destroy, quest1Start, mice, quest1Fin, quest2Start
}

public class IneractionDome : MonoBehaviour
{
    public interactTypes InteractXD;
}