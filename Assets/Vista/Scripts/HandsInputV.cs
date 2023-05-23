using System.Collections;
using System.Collections.Generic;
using UltimateXR.Examples.FullScene.Doors;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HandsInputV : MonoBehaviour
{

    public GameObject holoMap;
    public GameObject holoMap2;
    public GameObject laserLeft;
    public GameObject laserRight;
    //public GameObject controlsMenu;
    public List<GameObject> listInterfaces;

    public GameObject repairButton;

    public GameObject automaticDoorObject;
    AutomaticDoor automaticDoorScript;

    public GameObject menuInterface;

    public GameObject timerV;

    public GameObject activarInterface3;

    //public void UpdateControlMenu(bool state)
    //{
    //    controlsMenu.SetActive(state);
    //}
    public void UpdateHoloMap(bool state)
    {
        holoMap.SetActive(state);
    }
    public void UpdateHoloMap2(bool state)
    {
        holoMap2.SetActive(state);
    }

    public void UpdateLaserLeft(bool state)
    {
        laserLeft.SetActive(state);
    }

    public void UpdateLaserRight(bool state)
    {
        laserRight.SetActive(state);
    }

    public void SkipTutorial()
    {
        for(int i = 0; i < listInterfaces.Count; i++)
        {
            listInterfaces[i].SetActive(false);
        }

        automaticDoorScript = automaticDoorObject.GetComponent<AutomaticDoor>();

        automaticDoorScript.enabled = true;

        repairButton.SetActive(true);

        timerV.SetActive(true);

        activarInterface3.SetActive(false);
       
    }


    public void updateMenu(bool state)
    {
            menuInterface.SetActive(state);
      
    }
}
