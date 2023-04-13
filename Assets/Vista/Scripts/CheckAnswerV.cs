using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerV : MonoBehaviour
{
    public GameObject Button;

    public GameObject interfaceIncorrect;
    public GameObject exercise;

    public GameObject updateIFTuto;
    public GameObject panel1GrabCodeTuto;
    public GameObject panel2rabCodeTuto;

    public GameObject interfaceCorrectAnswer;

    public Luces lights;



    public void UpdateView(bool buttonDeploy)
    {
        Button.SetActive(buttonDeploy);
    }

    public void updateInterfaceGrabTuto() {


        panel1GrabCodeTuto.SetActive(false);
        panel2rabCodeTuto.SetActive(true);
    }

    public void correcAnswer()
    {
        lights.lightsGreen();
        updateIFTuto.SetActive(false);
        interfaceCorrectAnswer.SetActive(true);

    }
    public void incorrectAnswer()
    {
        interfaceIncorrect.SetActive(true);
        exercise.SetActive(false);
        updateIFTuto.SetActive(false);

    }

 

}
