using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    [SerializeField] Vector3 vectorVelocidad;
    [SerializeField] float velocidad;
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
            

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Rigidbody>().AddTorque(vectorVelocidad.normalized * velocidad, ForceMode.VelocityChange);
            //rb.AddTorque(vectorVelocidad.normalized * velocidad, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Rigidbody>().AddTorque(-vectorVelocidad.normalized * velocidad, ForceMode.VelocityChange);
            //rb.AddTorque(vectorVelocidad.normalized * velocidad, ForceMode.Impulse);

        }
    }
}
