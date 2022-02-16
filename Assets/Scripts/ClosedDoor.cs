using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedDoor : MonoBehaviour
{
    public bool isClosed = true;

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.CompareTag("Key"))
        {
            isClosed = false;
        }
    }
}
