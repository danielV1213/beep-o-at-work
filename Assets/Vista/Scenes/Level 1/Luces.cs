using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Luces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Si carga");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colosiona" + other.gameObject);

        if (other.gameObject.CompareTag("Player"))
        {
            // Agrega aqu� el c�digo que deseas que se ejecute cuando se active la colisi�n
            Debug.Log("Se ha activado la colisi�nNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");


            GameObject[] bombillos = GameObject.FindGameObjectsWithTag("Bombillo");

            // Cambia el color de la luz de todos los objetos "bombillo" a rojo
            foreach (GameObject bombillo in bombillos)
            {
                Light pointLight = bombillo.GetComponentInChildren<Light>();
                pointLight.color= Color.red;

            }

        }
    }

    public void lightsGreen(){

        GameObject[] bombillos = GameObject.FindGameObjectsWithTag("Bombillo");

            // Cambia el color de la luz de todos los objetos "bombillo" a rojo
            foreach (GameObject bombillo in bombillos)
            {
                Light pointLight = bombillo.GetComponentInChildren<Light>();
                pointLight.color= Color.green;

            }

    }

}
