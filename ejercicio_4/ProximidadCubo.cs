using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximidadCubo : MonoBehaviour
{
    public GameObject objetoReferencia;
    public float distanciaDeteccion = 5f;
    public GameObject huevoDestino;       // El huevo al que se teletransportan las arañas del grupo 1
    public GameObject objetivoGrupo2;     // El objeto hacia el que se orientan las arañas del grupo 2
    private bool evento_activado = false; // Evita que el evento se dispare múltiples veces

    void Update()
    {
        // Verifica la distancia entre el cubo y el objeto de referencia
        if (Vector3.Distance(transform.position, objetoReferencia.transform.position) <= distanciaDeteccion && !evento_activado)
        {
            TeletransportarAranasGrupo1();
            OrientarAranasGrupo2();
            evento_activado = true;
        }
    }

    // Teletransportar las arañas del grupo 1 al huevo
    void TeletransportarAranasGrupo1()
    {
        foreach (GameObject arana in GameObject.FindGameObjectsWithTag("araña_tipo_1"))
        {
            Rigidbody rbarana = arana.GetComponent<Rigidbody>();
            if (rbarana != null)
            {
                rbarana.MovePosition(huevoDestino.transform.position);  // Teletransportar de manera física
            }
        }
    }

    // Orientar las arañas del grupo 2 hacia el objetivo
    void OrientarAranasGrupo2()
    {
        foreach (GameObject arana in GameObject.FindGameObjectsWithTag("araña_tipo_2"))
        {
            if (objetivoGrupo2 != null) {
                Vector3 direccionObjetivo = (objetivoGrupo2.transform.position - transform.position).normalized;
                direccionObjetivo.y = 0;
                Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionObjetivo);
                Rigidbody rbarana = arana.GetComponent<Rigidbody>();
                float velocidadGiro = 1f;
                rbarana.MoveRotation(Quaternion.Slerp(rbarana.rotation, rotacionObjetivo, velocidadGiro * Time.fixedDeltaTime));
    }
        }
    }
}
