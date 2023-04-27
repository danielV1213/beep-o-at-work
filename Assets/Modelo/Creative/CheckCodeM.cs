using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCodeM : MonoBehaviour
{

    //PARA COMPARAR LA ETIQUETA O NOMBRE DE CADA BLOQUE DE CODIGO
    public List<string> ordenComplejidad = new List<string> {
        "constante",
        "lineal",
        "cuadratica",
        "logaritmica"
    };

    //PARA DESPLEGAR LA GRAFICA DEPENDIENDO EL RESULTADO
    public List<GameObject> listaGraficas = new List<GameObject>();

    //PARA SABER EN QUE ANCHOR PUSO EL BLOQUE DE CODIGO
    public List<GameObject> anchorPoints = new List<GameObject>();



}
