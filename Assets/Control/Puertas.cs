using System.Collections;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public Transform puertaIzquierda;
    public Transform puertaDerecha;
    public float velocidadDeApertura = 2.0f;
    private bool puertasAbiertas = false;
    private Vector3 posicionInicialIzquierda;
    private Vector3 posicionInicialDerecha;

    private void Start()
    {
        // Guardar la posición inicial de las puertas
        posicionInicialIzquierda = puertaIzquierda.position;
        posicionInicialDerecha = puertaDerecha.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !puertasAbiertas)
        {
            // Si el jugador colisiona con el objeto por primera vez,
            // las puertas se abren hacia los lados.
            puertasAbiertas = true;
            StartCoroutine(AbrirPuertas());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && puertasAbiertas)
        {
            // Si el jugador sale de la colisión y las puertas están abiertas,
            // las puertas se cierran hacia el centro.
            puertasAbiertas = false;
            StartCoroutine(CerrarPuertas());
        }
    }

    IEnumerator AbrirPuertas()
    {
        float aperturaActual = 0f;
        Vector3 posicionFinalIzquierda = posicionInicialIzquierda + Vector3.left * 2f;
        Vector3 posicionFinalDerecha = posicionInicialDerecha + Vector3.right * 2f;

        while (aperturaActual < 1f)
        {
            aperturaActual += Time.deltaTime * velocidadDeApertura;
            puertaIzquierda.position = Vector3.Lerp(posicionInicialIzquierda, posicionFinalIzquierda, aperturaActual);
            puertaDerecha.position = Vector3.Lerp(posicionInicialDerecha, posicionFinalDerecha, aperturaActual);
            yield return null;
        }
    }

    IEnumerator CerrarPuertas()
    {
        float cierreActual = 0f;

        while (cierreActual < 1f)
        {
            cierreActual += Time.deltaTime * velocidadDeApertura;
            puertaIzquierda.position = Vector3.Lerp(puertaIzquierda.position, posicionInicialIzquierda, cierreActual);
            puertaDerecha.position = Vector3.Lerp(puertaDerecha.position, posicionInicialDerecha, cierreActual);
            yield return null;
        }
    }
}
