using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Examples.FullScene.Doors;
public class InterfaceC : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> listUI;
    public int contList = 0;
    public int contListPrev = 0;

    public GameObject automaticDoorObject;
    AutomaticDoor automaticDoorScript;

    public GameObject repairButtonObj;

    public GameObject interfaceExercise;
    public GameObject interfaceGrabCode;
   

    public GameObject interfaceTuto2;

    public GameObject timer;
    public TimerV timerV;

    public Luces lightsC;

    void Start()
    {
        listUI[0].SetActive(true);

        for (int i = 1; i < listUI.Count; i++)
        {
            listUI[i].SetActive(false);
        }



        if (this.gameObject.name == "Interface1")
        {
            automaticDoorScript = automaticDoorObject.GetComponent<AutomaticDoor>();

            automaticDoorScript.enabled = false;
        }

      
    }


    public void onButtonPressed() {


        listUI[contListPrev].SetActive(false);
        contList = contListPrev + 1;
        listUI[contList].SetActive(true);
        contListPrev = contList;

        if(this.gameObject.name == "Interface1")
        {

            if (listUI[contList].name == "PanelGeneradrorRoto")
            {
                automaticDoorScript.enabled = true;

                lightsC.lightsRed();

            }
 
        }

        if (this.gameObject.name == "Interface3")
        {

            if (listUI[contList].name == "PanelReparar")
            {
               
                repairButtonObj.SetActive(true);

            }

            if (listUI[contList].name == "PanelTimer")
            {

                timer.SetActive(true);

            }
        }

    }

    public void closeCanvas()
    {

        this.gameObject.SetActive(false);
     
    }


    public void StartExercise()
    {
  
        interfaceTuto2.SetActive(false);

        repairButtonObj.SetActive(false);

        interfaceExercise.SetActive(true);

        interfaceGrabCode.SetActive(true);
    }

    public void timerStart()
    {

        timerV.startCount();

    }

}
