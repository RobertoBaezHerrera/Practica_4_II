using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arana_notificador : MonoBehaviour
{
    public delegate void ColisionArana();
    public static event ColisionArana OnAranaColision;
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
            if (OnAranaColision != null) { // Verifica si hay suscriptores.
                OnAranaColision();  // Lanza el evento
            }
            Debug.Log("Colisión de Arana con: " + other.gameObject.tag);
        }
    }
}
