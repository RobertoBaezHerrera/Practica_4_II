using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AranaTipo2 : MonoBehaviour
{
    public GameObject huevo;
    public float velocidad = 5f;
    private bool movimiento_activo = false;
    public float distanciaTolerancia = 0.1f;
    Rigidbody rbarana;
    // Start is called before the first frame update
    void Start()
    {
        HuevoNotificador.OnHuevoColision += ActivarMovimiento;
        rbarana = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento_activo) {
            // Mover la arana tipo 1 hacia la arana tipo 2
            Transform huevoDestino = huevo.GetComponent<Transform>();
            Vector3 direccion = new Vector3(huevoDestino.position.x - transform.position.x, transform.position.y, huevoDestino.position.z - transform.position.z);
            rbarana.AddForce(new Vector3(direccion.x, 0f, direccion.z).normalized * velocidad, ForceMode.Force);
        }
    }

    private void OnDestroy() {
        // Desuscribirse cuando el objeto se destruya
        HuevoNotificador.OnHuevoColision -= ActivarMovimiento;
    }

    // Función que se llama cuando se dispara el evento
    void ActivarMovimiento() {
        movimiento_activo = true;
    }
}
