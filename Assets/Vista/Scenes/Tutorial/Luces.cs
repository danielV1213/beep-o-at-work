using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Luces : MonoBehaviour
{
    // Start is called before the first frame update
 
    public CheckAnswerC checkC;

    public GameObject lightsGreenObj;
    //public Material materialLight;


    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Colosiona" + other.gameObject);

    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        // Agrega aquí el código que deseas que se ejecute cuando se active la colisión
    //        //Debug.Log("Se ha activado la colisiónNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");


    //        GameObject[] bombillos = GameObject.FindGameObjectsWithTag("Bombillo");

    //        // Cambia el color de la luz de todos los objetos "bombillo" a rojo
    //        foreach (GameObject bombillo in bombillos)
    //        {
    //            Light pointLight = bombillo.GetComponentInChildren<Light>();
    //            pointLight.color= Color.red;

    //        }

    //    }
    //}

    public void lightsGreen()
    {
    
            lightsGreenObj.SetActive(true);
            Debug.Log("ANSWER CORRECT SAPA");

            this.gameObject.SetActive(false);

       
    }
    public void lightsRed()
    {
      
            GameObject[] bombillos = GameObject.FindGameObjectsWithTag("Bombillo");

            // Cambia el color de la luz de todos los objetos "bombillo" a rojo
            foreach (GameObject bombillo in bombillos)
            {
                Light pointLight = bombillo.GetComponentInChildren<Light>();
                pointLight.color = Color.red;

            }

        //materialLight.color = Color.red;

    }


}
