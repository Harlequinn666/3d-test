using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    //int health = 5;
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.I))
        //{
        //    health -= 1;
        //}

        //else
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("play");
        }
    }
}
