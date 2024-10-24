using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActualizadorDePuntuacionUI : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public TextMeshProUGUI recompensaTexto;
    private int puntuacionTotal = 0;
    private int puntosPorRecompensa = 100;
    int numeroRecompensa = 1;

    // Ejercicio 8
    public float factorCrecimiento = 1.5f;
    public GameObject aranaCreciente;

    private void Start()
    {
        recompensaTexto.text = ""; // No hay recompensa al inicio
    }

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

    // Método que actualiza la puntuación en la UI
    private void ActualizarPuntuacion(int puntos)
    {
        puntuacionTotal += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacionTotal.ToString(); // Actualizar el texto en la UI
        Debug.Log("Puntuación actual: " + puntuacionTotal); // También imprime la puntuación en consola
        if (puntuacionTotal >= puntosPorRecompensa && puntuacionTotal % puntosPorRecompensa == 0)
        {
            MostrarRecompensa(numeroRecompensa);
            ++numeroRecompensa;
            CrecerArana();
        }
    }

    private void MostrarRecompensa(int numeroRecompensa)
    {
        recompensaTexto.text = "¡Recompensa " + numeroRecompensa + " obtenida!"; 
        // Aquí podrías agregar otra lógica para dar una recompensa adicional (por ejemplo, una habilidad, bonus, etc.)
        Debug.Log("Recompensa " + numeroRecompensa + " otorgada");
    }

    void CrecerArana()
    {
        if (aranaCreciente != null)
        {
            // Aumentar el tamaño de la araña multiplicando su escala
            aranaCreciente.transform.localScale *= factorCrecimiento;
        }
    }
}