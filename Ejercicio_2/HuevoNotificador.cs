using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoNotificador : MonoBehaviour
{
    public delegate void ColisionHuevo();
    public static event ColisionHuevo OnHuevoColision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Detectar colisiones físicas usando OnCollisionEnter
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "cubo") {
            if (OnHuevoColision != null) { // Verifica si hay suscriptores.
                OnHuevoColision();  // Lanza el evento
            }
            Debug.Log("Colisión de Huevo con: " + other.gameObject.tag);
        }
    }
}
