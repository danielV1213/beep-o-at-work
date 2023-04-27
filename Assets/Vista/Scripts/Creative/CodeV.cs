using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeV : MonoBehaviour
{
    public Image imagen;
    Color colorOriginal;

    private void Start()
    {
        colorOriginal = imagen.color;
    }

    public void changeColorToOriginal()
    {
        imagen.color = colorOriginal;
    }

    public void changeColorOpacity()
    {
        Color colorConMenorOpacidad = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0.6f);
        imagen.color = colorConMenorOpacidad;
    }
}
