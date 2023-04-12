using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsInputV : MonoBehaviour
{

    public GameObject holoMap;
    public GameObject laserLeft;
    public GameObject laserRight;
    public List<GameObject> listInterfaces;


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
    }


}
