using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorDePuntos : MonoBehaviour
{
    private int puntuacionTotal = 0;

    void OnEnable()
    {
        // Suscribirse al evento de recolección de arañas
        NotificadorDeColisiones.OnRecoleccionAraña += ActualizarPuntuacion;
    }

    void OnDisable()
    {
        // Desuscribirse cuando el objeto se destruya o se desactive
        NotificadorDeColisiones.OnRecoleccionAraña -= ActualizarPuntuacion;
    }

    // Método que se ejecuta cuando se notifica la recolección de una araña
    private void ActualizarPuntuacion(int puntos)
    {
        puntuacionTotal += puntos;
        Debug.Log("Puntuación actual: " + puntuacionTotal);
    }
}