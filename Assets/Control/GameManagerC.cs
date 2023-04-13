using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerC : MonoBehaviour
{

    public float time;
    public void timeSinceStart()
    {
        time = Time.realtimeSinceStartup;
        int minutos = Mathf.FloorToInt(time / 60f);
        int segundos = Mathf.FloorToInt(time % 60f);

        Debug.Log("Tiempo: " + minutos + " minutos " + segundos + " segundos");

    }

    private void Update()
    {
        time = Time.realtimeSinceStartup;

        if (time >= 1800)
        {

        }
    }

}
