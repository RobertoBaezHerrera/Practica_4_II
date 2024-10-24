using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferasTipo2 : MonoBehaviour
{
    public GameObject cilindro;
    public float velocidad = 2f;
    bool moviemiento_activado = false;
    // Start is called before the first frame update
    void Start()
    {
        CilindroNotificador.OnCilindroColision += MoverHaciaCilindro;
    }

    // Update is called once per frame
    void Update()
    {
        if (moviemiento_activado) {
            // Mover la esfera tipo 2 hacia el cilindro
            Transform cilindroDestino = cilindro.transform;
            Vector3 direccion = (cilindroDestino.position - transform.position);
            transform.Translate(new Vector3(direccion.x - 1, direccion.y, direccion.z - 1) * velocidad * Time.deltaTime);
        }
    }

    private void OnDestroy() {
        // Desuscribirse cuando el objeto se destruya
        CilindroNotificador.OnCilindroColision -= MoverHaciaCilindro;
    }

    void MoverHaciaCilindro() {
        moviemiento_activado = true;
    }
}
