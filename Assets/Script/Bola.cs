using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
   
        
    Rigidbody rb;
    Vector3 direccionF = new Vector3(0, 1, 0);
    Vector3 direccionF2 = new Vector3(0, 0, 1);
    Vector3 direccionF3 = new Vector3(1, 0, 0);
    [SerializeField] float fuerza;
    [SerializeField] float velocidad;
   
    
    
    int puntos;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //textoPuntos.SetText("Puntuacion: " + puntos);
    }

    // Update is called once per frame
    void Update()
    {
       
       
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

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3 (Input.GetAxisRaw("Horizontal"),0,0).normalized * velocidad, ForceMode.Force);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            
            puntos += 10;
            //textoPuntos.SetText("Puntuacion: " + puntos);

        } 
        if (other.gameObject.CompareTag("Muros"))
        {
            Destroy(gameObject);
            puntos -= 10;
            //textoPuntos.SetText("Puntuacion: " + puntos);

        }
    }

   

}
