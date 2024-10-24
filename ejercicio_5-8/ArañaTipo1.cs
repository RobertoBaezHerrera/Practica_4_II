using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArañaTipo1 : MonoBehaviour
{
    private int puntos = 10;  // Puntos que otorga la araña tipo 1

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asumimos que el cubo tiene el tag "Player"
        {
            // Notificamos al sistema que se ha recolectado una araña
            NotificadorDeColisiones.NotificarRecoleccion(puntos);
            Debug.Log("Araña Tipo 1 recogida.");

            // Destruir o desactivar la araña tras la recolección
            Destroy(gameObject);
        }
    }
}