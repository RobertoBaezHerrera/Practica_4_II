using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AranaTipo1 : MonoBehaviour
{
    public GameObject arana_tipo2;
    public float velocidad = 12f;
    private bool movimiento_activo = false;
    Rigidbody rbarana;
    Vector3 vector1 = Vector3.one;
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
            Transform aranaTipo2Destino = arana_tipo2.GetComponent<Transform>();
            Vector3 direccion = new Vector3(aranaTipo2Destino.position.x - transform.position.x, transform.position.y, aranaTipo2Destino.position.z - transform.position.z);
            rbarana.AddForce(new Vector3(direccion.x, direccion.y, direccion.z).normalized * velocidad, ForceMode.Force);
            
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
