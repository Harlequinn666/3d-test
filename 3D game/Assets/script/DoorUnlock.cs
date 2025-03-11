using System;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public Animator doorAnimator; // Assign an animator for door opening animation

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<PlayerInventory>().hasKey)
        {
            doorAnimator.SetTrigger("Open"); // Triggers the animation
            //Destroy(gameObject, 2f); // (Optional) Destroy door after opening
        }
    }

}
