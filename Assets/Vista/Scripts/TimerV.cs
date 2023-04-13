using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerV : MonoBehaviour
{
    public float timeUpdate;
    public float timeLimit = 150;

    public TextMeshProUGUI textTimerMin;
    public TextMeshProUGUI textTimerSec;

 
    // Start is called before the first frame update
    void Start()
    {
        timeUpdate = 150;
    }

    // Update is called once per frame
    void Update()
    {
        timeUpdate -= Time.deltaTime;

        int minutos = Mathf.FloorToInt(timeUpdate / 60f);
        int segundos = Mathf.FloorToInt(timeUpdate % 60f);

        textTimerMin.text = "" + minutos;
        textTimerSec.text = "" + segundos;
   

    }

    public void timeSeparate()
    {

        //int minutos = Mathf.FloorToInt(time / 60f);
        //int segundos = Mathf.FloorToInt(time % 60f);

       

    }

}
