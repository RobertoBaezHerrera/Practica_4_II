using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoCambiaColor : MonoBehaviour
{
    bool cambiar_color = false;
    // Start is called before the first frame update
    void Start()
    {
        HuevoNotificador2.OnHuevoColision += ActivaCambiarColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (cambiar_color) {
            Color color_huevo = GetComponent<MeshRenderer>().material.color;
            color_huevo = new Color(Random.value, Random.value, Random.value);
        }
    }

    private void OnDestroy() {
        HuevoNotificador2.OnHuevoColision -= ActivaCambiarColor;
    }

    void ActivaCambiarColor() {
        Debug.Log("CAMBIAR COLOR");
        cambiar_color = true;
    }
}
