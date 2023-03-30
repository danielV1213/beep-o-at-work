using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Devices;
using UnityEngine;

public class LeftHandInputHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject holoMap;
    public bool holoMapState = false;


    public GameObject laserLeft;
    public GameObject laserRight;
    public bool laserLeftState = false;
    public bool laserRightState = false;

    void Start()
    {
        holoMap.SetActive(holoMapState);
    }   

    // Update is called once per frame
    void Update()
    {
        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button2))
        {
          
            holoMap.SetActive(holoMapState);
            holoMapState = !holoMapState;
        }

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button1))
        {
          
            laserLeft.SetActive(laserLeftState);
            laserLeftState = !laserLeftState;
        }

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Right, UxrInputButtons.Button1))
        {
      
            laserRight.SetActive(laserRightState);
            laserRightState = !laserRightState;
        }

    }


}
