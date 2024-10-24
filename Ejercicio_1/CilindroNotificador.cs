using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroNotificador : MonoBehaviour
{
    public delegate void ColisionCilindro();
    public static event ColisionCilindro OnCilindroColision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Detectar colisiones físicas usando OnCollisionEnter
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "cubo") {
            if (OnCilindroColision != null) { // Verifica si hay suscriptores.
                OnCilindroColision();  // Lanza el evento
            }
            Debug.Log("Colisión Física de Cilindro con: " + other.gameObject.tag);
        }
    }
}
