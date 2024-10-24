using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificadorDeColisiones : MonoBehaviour
{
    // Definimos un delegado y un evento para notificar la recolección
    public delegate void RecoleccionAraña(int puntos);
    public static event RecoleccionAraña OnRecoleccionAraña;

    public static void NotificarRecoleccion(int puntos)
    {
        // Dispara el evento si hay observadores suscritos
        if (OnRecoleccionAraña != null)
        {
            OnRecoleccionAraña(puntos);
        }
    }
}