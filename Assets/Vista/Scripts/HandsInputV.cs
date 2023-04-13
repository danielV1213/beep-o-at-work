using System.Collections;
using System.Collections.Generic;
using UltimateXR.Examples.FullScene.Doors;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HandsInputV : MonoBehaviour
{

    public GameObject holoMap;
    public GameObject laserLeft;
    public GameObject laserRight;
    public List<GameObject> listInterfaces;

    public GameObject repairButton;

    public GameObject automaticDoorObject;
    AutomaticDoor automaticDoorScript;

    public GameObject menuInterface;

    public void UpdateHoloMap(bool state)
    {
        holoMap.SetActive(state);
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
       
    }


    public void updateMenu(bool state)
    {
            menuInterface.SetActive(state);
      
    }
}
