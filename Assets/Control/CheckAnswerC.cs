using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerC : MonoBehaviour
{
    private CheckAnswerM checkAnswerM;
    private CheckAnswerV checkAnswerV;

    private void Start()
    {
        checkAnswerM = new CheckAnswerM();
        checkAnswerV = GetComponent<CheckAnswerV>();
        checkAnswerV.UpdateView(false);
    }
    
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("correctCard"))
        {
            checkAnswerM.CorrectAnswer = true;
            //Debug.Log(other.gameObject.tag);
            checkAnswerV.UpdateView(true);
        }
        else
        {
            //Debug.Log(other.gameObject.tag);
            checkAnswerM.CorrectAnswer = false;
            checkAnswerV.UpdateView(true);
        }
    }


    public void OnTriggerExit(Collider other)
    {
        checkAnswerV.UpdateView(false);
    }

    public void OnCheckAnswerButtonClicked()
    {
        checkAnswerM.CheckAnswer();
    }



}
