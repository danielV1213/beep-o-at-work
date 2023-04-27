using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeM : MonoBehaviour
{

    public enum MyEnum { constante, lineal, logaritmica, cuadratica };

    [SerializeField]
    private MyEnum selectedValue;

    private static readonly MyEnum[] myValues = { MyEnum.constante, MyEnum.lineal, MyEnum.logaritmica, MyEnum.cuadratica };

    public MyEnum SelectedValue
    {
        get { return selectedValue; }
    }


}
