using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    public bool active = false;
    public GameObject interfaceActive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !active)
        {
            interfaceActive.SetActive(true);
            active = true;
        }
       
    }

}
