using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCodeM : MonoBehaviour
{

    //PARA COMPARAR LA ETIQUETA O NOMBRE DE CADA BLOQUE DE CODIGO
    public Dictionary<string, string> ordersComplexity = new Dictionary<string, string>{
        { "constante", "O(1)" },
        { "lineal", "O(n)" },
        { "logaritmica", "O(Log n)" },
        { "cuadratica", "O(n^2)" }
    };


    ////PARA DESPLEGAR LA GRAFICA DEPENDIENDO EL RESULTADO
    //public List<GameObject> listaGraficas = new List<GameObject>();

    ////PARA SABER EN QUE ANCHOR PUSO EL BLOQUE DE CODIGO
    //public List<GameObject> anchorPoints = new List<GameObject>();



}
