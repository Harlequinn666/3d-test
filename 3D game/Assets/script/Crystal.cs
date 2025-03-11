using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Console.WriteLine("You have collected the ultimate Crystal");
            Destroy(gameObject); // Remove the key after pickup
            EditorApplication.isPlaying = false;
        }
    }
}
