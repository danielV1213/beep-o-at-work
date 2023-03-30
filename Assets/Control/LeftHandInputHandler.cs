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
    void Start()
    {
        holoMap.SetActive(holoMapState);
    }   

    // Update is called once per frame
    void Update()
    {
        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button2))
        {
            // do stuff
            //Debug.Log("SIIIIIIII TRIGGER");
            holoMap.SetActive(holoMapState);
            holoMapState = !holoMapState;
        }

    }


}
