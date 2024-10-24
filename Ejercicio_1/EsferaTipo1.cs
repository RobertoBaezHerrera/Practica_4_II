using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaTipo1 : MonoBehaviour
{
    public GameObject esfera_tipo2;
    public float velocidad = 2f;
    private bool movimiento_activo = false;
    // Start is called before the first frame update
    void Start()
    {
        CilindroNotificador.OnCilindroColision += ActivarMovimiento;
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento_activo) {
            // Mover la esfera tipo 1 hacia la esfera tipo 2
            Transform esferaTipo2Destino = esfera_tipo2.GetComponent<Transform>();
            Vector3 direccion = (esferaTipo2Destino.position - transform.position);
            transform.Translate(new Vector3(direccion.x - 1, direccion.y, direccion.z - 1).normalized * velocidad * Time.deltaTime);
        }
    }

    private void OnDestroy() {
        // Desuscribirse cuando el objeto se destruya
        CilindroNotificador.OnCilindroColision -= ActivarMovimiento;
    }

    // Función que se llama cuando se dispara el evento
    void ActivarMovimiento() {
        movimiento_activo = true;
    }
}
