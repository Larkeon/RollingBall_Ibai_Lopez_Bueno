using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direccionF = new Vector3(0, 1, 0);
    Vector3 direccionF2 = new Vector3(0, 0, 1);
    Vector3 direccionF3 = new Vector3(1, 0, 0);
    [SerializeField] int fuerza;
    [SerializeField] int fuerzaws;
    [SerializeField] int fuerzaad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3 (Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized, ForceMode.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(direccionF  , ForceMode.Impulse);
        }
        //
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(direccionF2 * fuerzaws, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(direccionF2 * -fuerzaws, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(direccionF3 * fuerzaad, ForceMode.Force);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(direccionF3 * -fuerzaad, ForceMode.Force);
        //}



    }
}
