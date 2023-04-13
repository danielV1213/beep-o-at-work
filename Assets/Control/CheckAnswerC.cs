using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerC : MonoBehaviour
{
    public CheckAnswerM checkAnswerM;
    private CheckAnswerV checkAnswerV;

    public GameObject interfaceIncorrect;
    public GameObject mainCard;

    public Luces lights;

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
        //checkAnswerM.CheckAnswer();
        if (checkAnswerM.CorrectAnswer)
        {
            lights.lightsGreen();
        }
        else
        {
            interfaceIncorrect.SetActive(true);
            mainCard.SetActive(false);

        }
      

    }






}
