using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direccionF = new Vector3(0, 1, 0);
    Vector3 direccionF2 = new Vector3(0, 0, 1);
    Vector3 direccionF3 = new Vector3(1, 0, 0);
    [SerializeField] float fuerza;
    [SerializeField] float fuerzaws;
    [SerializeField] float fuerzaad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(direccionF * fuerza, ForceMode.Impulse);
        }
        while (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(direccionF2 * fuerzaws, ForceMode.Force);
        }
        while (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(direccionF2 * -fuerzaws, ForceMode.Force);
        }
        while (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(direccionF3 * fuerzaad, ForceMode.Force);
        }
        while (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(direccionF3 * -fuerzaad, ForceMode.Force);
        }

        

        
    }
}
