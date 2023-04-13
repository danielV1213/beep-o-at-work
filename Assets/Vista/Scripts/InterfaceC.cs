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
    public GameObject timer;



    void Start()
    {
        listUI[0].SetActive(true);


        if(this.gameObject.name == "Interface1")
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

            if (contList == 3)
            {
                automaticDoorScript.enabled = true;
            }else if (contList == 2)
            {
                //LUCES SE PONGAN ROJAS Y SUENE LA ALARMA
            }
        }

  

    }

    public void closeCanvas()
    {

        this.gameObject.SetActive(false);
        repairButtonObj.SetActive(true);


    }


    public void StartExercise()
    {
        interfaceExercise.SetActive(true);
        interfaceGrabCode.SetActive(true);
        

    }

    public void timerStart()
    {

        timer.SetActive(true);

    }

}
