using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moverCubo : MonoBehaviour
{
    public float speed = 15f;
    Rigidbody rbcubo;
    Vector3 moveDirectionCubo;
    // Start is called before the first frame update
    void Start()
    {
        rbcubo = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveDirectionCubo = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveDirectionCubo += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDirectionCubo += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A)) {
            moveDirectionCubo += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            moveDirectionCubo += new Vector3(1, 0, 0);
        }
        rbcubo.AddForce(moveDirectionCubo.normalized * speed, ForceMode.Force);
        
    }
}
