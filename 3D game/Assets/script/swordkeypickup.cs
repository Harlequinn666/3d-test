using UnityEngine;

public class swordkeypickup : MonoBehaviour
{
    private bool isCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;
            other.GetComponent<PlayerInventory>().hasKey = true;
            Destroy(gameObject); // Remove the key after pickup
        }
    }
}
