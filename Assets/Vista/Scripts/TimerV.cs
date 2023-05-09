using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerV : MonoBehaviour
{
    public float timeUpdate;
    public float timeLimit = 150;

    public TextMeshProUGUI textTimerMin;
    public TextMeshProUGUI textTimerSec;

    public TextMeshProUGUI textTime;

    public bool startExercise = false;



    // Start is called before the first frame update
    void Start()
    {
        timeUpdate = 150;
        //textTimerMin.text = "02";
        //textTimerSec.text = "30";
        int minutos = Mathf.FloorToInt(timeUpdate / 60f);
        int segundos = Mathf.FloorToInt(timeUpdate % 60f);

        textTime.text = string.Format("{00:00}:{01:00}", minutos, segundos);
    }

    // Update is called once per frame
    void Update()
    {

        if(startExercise)
        {
            timeUpdate -= Time.deltaTime;

            int minutos = Mathf.FloorToInt(timeUpdate / 60f);
            int segundos = Mathf.FloorToInt(timeUpdate % 60f);

            textTime.text = string.Format("{00:00}:{01:00}",minutos,segundos);

            //textTimerMin.text = "" + minutos;
            //textTimerSec.text = "" + segundos;
        }
      
    }
    public void startCount()
    {
        startExercise = true;
    }

    internal void timeRestart()
    {
        timeUpdate = 150;
        textTimerMin.text = "02";
        textTimerSec.text = "30";
    }
}
