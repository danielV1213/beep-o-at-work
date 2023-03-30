using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCode : MonoBehaviour
{
    // Start is called before the first frame update

    public bool correctAnswer = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnTriggerStay(Collider other)
    //{
    //    Debug.Log(other.tag);
    //}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Canva"))
        {
            Debug.Log(other.gameObject.name + "STAYYYYYYYY");

            if (other.gameObject.name == "IV_IF_CodeCard_1")
            {
                correctAnswer = true;
                Debug.Log("CORRECTOOOOOOOOOOOOO   " + other.gameObject.name);
            }
            else
            {
                correctAnswer = false;
                Debug.Log("HUEVAAAAAAAAAAAAAAAAA");
            }
        }
     
    }
}
