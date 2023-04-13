using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Devices;
using UnityEngine;

public class HandsInputC : MonoBehaviour
{
    private HandsInputM inputModel;
    private HandsInputV inputView;

    public Luces lights;
    public int contPressButtonTime = 0;
    void Start()
    {
        inputModel = new();
        inputView = GetComponent<HandsInputV>();
        inputView.UpdateHoloMap(inputModel.HoloMapState);
    }

    // Update is called once per frame
    void Update()
    {
        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button2))
        {
            inputModel.HoloMapState = !inputModel.HoloMapState;
            inputView.UpdateHoloMap(inputModel.HoloMapState);
        }

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button1))
        {
            inputModel.LaserLeftState = !inputModel.LaserLeftState;
            inputView.UpdateLaserLeft(inputModel.LaserLeftState);
        }

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Right, UxrInputButtons.Button1))
        {
            inputModel.LaserRightState = !inputModel.LaserRightState;
            inputView.UpdateLaserRight(inputModel.LaserRightState);
        }


        if (contPressButtonTime >= 100)
        {
            inputModel.TutoOMitir = true;

            inputView.SkipTutorial();
            lights.lightsRed();

        }

    }



    private void FixedUpdate()
    {
        if (!inputModel.TutoOMitir)
        {
            if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UxrHandSide.Right, UxrInputButtons.Button1))
            {
                contPressButtonTime++;
            }
            if (UxrAvatar.LocalAvatarInput.GetButtonsPressUp(UxrHandSide.Right, UxrInputButtons.Button1))
            {
                contPressButtonTime = 0;
            }
        }
    }
}
