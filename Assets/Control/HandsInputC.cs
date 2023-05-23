using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Devices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandsInputC : MonoBehaviour
{
    private HandsInputM inputModel;
    private HandsInputV inputView;

    public Luces lights;
    public int contPressButtonTime = 0;


    public bool stateMenu = false;
    void Start()
    {
        inputModel = new();
        inputView = GetComponent<HandsInputV>();
        inputView.UpdateHoloMap(inputModel.HoloMapState);

        //inputView.UpdateControlMenu(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button2))
        {
            inputModel.HoloMapState = !inputModel.HoloMapState;
            inputView.UpdateHoloMap(inputModel.HoloMapState);
        }

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Right, UxrInputButtons.Button2))
        {
            inputModel.HoloMap2State = !inputModel.HoloMap2State;
            inputView.UpdateHoloMap2(inputModel.HoloMap2State);
        }

        //if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button1))
        //{
        //    inputModel.LaserLeftState = !inputModel.LaserLeftState;
        //    inputView.UpdateLaserLeft(inputModel.LaserLeftState);
        //}

        //if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Right, UxrInputButtons.Button1))
        //{
        //    inputModel.LaserRightState = !inputModel.LaserRightState;
        //    inputView.UpdateLaserRight(inputModel.LaserRightState);
        //}

        if (UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Menu))
        {
            if (SceneManager.GetActiveScene().name != "Menu")
            {  
                inputView.updateMenu(stateMenu);
                stateMenu = !stateMenu;
            }
            
        }


        if (contPressButtonTime >= 100 && !inputModel.TutoOMitir)
        {
            inputModel.TutoOMitir = true;

            inputView.SkipTutorial();
            lights.lightsRed();



        }

        //if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UxrHandSide.Left, UxrInputButtons.Menu))
        //{
        //    Debug.Log("Ver controles");
        //    inputView.UpdateControlMenu(true);

        //}
        //if (UxrAvatar.LocalAvatarInput.GetButtonsPressUp(UxrHandSide.Left, UxrInputButtons.Menu))
        //{
        //    inputView.UpdateControlMenu(false);
        //}
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
