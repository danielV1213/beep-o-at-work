using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerV : MonoBehaviour
{
    public GameObject Button;
   
    public void UpdateView(bool buttonDeploy)
    {
        Button.SetActive(buttonDeploy);
    }


}
