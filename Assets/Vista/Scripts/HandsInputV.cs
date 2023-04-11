using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsInputV : MonoBehaviour
{

    public GameObject holoMap;
    public GameObject laserLeft;
    public GameObject laserRight;

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
}
