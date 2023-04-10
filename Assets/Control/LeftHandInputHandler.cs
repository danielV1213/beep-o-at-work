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
    public bool tutoOMitir = false;

    void Start()
    {
        holoMap.SetActive(holoMapState);
    }

    // Update is called once per frame
    void Update()
    {
        if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UxrHandSide.Left, UxrInputButtons.Button2))
        //.GetButtonsPressDown(UxrHandSide.Left, UxrInputButtons.Button2))
        {
            Debug.Log("ESTAA PRESIONADo");
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




        if (cont >= 100)
        {
            tutoOMitir = true;
            cont = 0;
            GameObject objeto = this.gameObject;
            Vector3 nuevaPosicion = new Vector3(1, 0, 0);
            objeto.transform.position = nuevaPosicion;
        }

    }
    public int cont = 0;
    private void FixedUpdate()
    {
        if (!tutoOMitir)
        {
            if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UxrHandSide.Right, UxrInputButtons.Button1))
            {
                cont++;
            }
            if (UxrAvatar.LocalAvatarInput.GetButtonsPressUp(UxrHandSide.Right, UxrInputButtons.Button1))
            {
                cont = 0;
            }
        }

    }


}
