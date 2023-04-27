using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeC : MonoBehaviour
{
    public CodeV codeV;
    public CodeM codeM;
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            codeV.changeColorOpacity();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            codeV.changeColorToOriginal();
        }
    }

}
