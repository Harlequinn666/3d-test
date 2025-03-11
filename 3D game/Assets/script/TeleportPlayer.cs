using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform Areatwo;
    public Transform Areathree;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "AreaOneCrystal")
        {
            transform.position = Areatwo.transform.position;
        }
        if (other.name == "AreaTwoCrystal")
        {
            transform.position = Areathree.transform.position;
        }
    }

}
