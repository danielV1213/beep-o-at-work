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

    public GameObject buttonProbar;



    public SpawnAnswerC spawnAnswerC;
    public TimerV timerV;

    public void UpdateView(bool buttonDeploy)
    {
        Button.SetActive(buttonDeploy);
    }

    public void updateInterfaceGrabTuto() {


        panel1GrabCodeTuto.SetActive(false);
        panel2rabCodeTuto.SetActive(true);
    }

    public void correctAnswer()
    {
        lights.lightsGreen();
        updateIFTuto.SetActive(false);
        interfaceCorrectAnswer.SetActive(true);
        exercise.SetActive(false);

    }
    public void incorrectAnswer()
    {
        interfaceIncorrect.SetActive(true);
        exercise.SetActive(false);
        updateIFTuto.SetActive(false);

    }

 
    public void restartExercise()
    {
        timerV.timeRestart();
        spawnAnswerC.ChangeAnswers();
        interfaceIncorrect.SetActive(false);
        exercise.SetActive(true);
    }

}
