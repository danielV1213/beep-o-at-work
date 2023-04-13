using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerC : MonoBehaviour
{

    public float timeUpdate;
    public float lastTime;
    public void timeSinceStart()
    {
      
        int minutos = Mathf.FloorToInt(lastTime / 60f);
        int segundos = Mathf.FloorToInt(lastTime % 60f);

        Debug.Log("Tiempo: " + minutos + " minutos " + segundos + " segundos");

    }

    private void Update()
    {
        timeUpdate = Time.realtimeSinceStartup;

        if (timeUpdate >= 1800)
        {
            lastTime = timeUpdate;
            timeSinceStart();

            Debug.Log("ALERTA, LLEVAS MUCHO TIEMPO JUGANDO");
        }

        if (timeUpdate >= 20)
        {
            lastTime = timeUpdate;
            timeSinceStart();
        }
    }

}
