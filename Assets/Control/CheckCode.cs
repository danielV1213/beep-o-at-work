using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCode : MonoBehaviour
{
    // Start is called before the first frame update

    public bool correctAnswer = false;
    public bool buttonDeploy = false;
    public GameObject button;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        button.SetActive(buttonDeploy);
    }

    public void OnTriggerStay(Collider other)
    {

        if(other.gameObject.CompareTag("correctCard"))
        {
            correctAnswer = true;
            Debug.Log(other.gameObject.tag);
            buttonDeploy = true;
        }
        else
        {
            Debug.Log(other.gameObject.tag);
            correctAnswer = false;
            buttonDeploy = true;
        }

    }

    
    private void OnTriggerExit(Collider other)
    {
        buttonDeploy = false;
    }

    public void CheckAnswer()
    {
        Debug.Log(correctAnswer);
    }

}
