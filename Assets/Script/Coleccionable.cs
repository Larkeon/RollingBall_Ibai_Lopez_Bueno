using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    Vector3 vectorVelocidad = new Vector3(0,1,0);
    Vector3 vectorVelocidad2 = new Vector3(0,1,0);
    [SerializeField] float velocidad;
    [SerializeField] float velocidad2;
    float contador = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vectorVelocidad.normalized * velocidad, Space.World);

        if (contador > 0)
        {
            contador -= Time.deltaTime;
            transform.Translate(vectorVelocidad2.normalized * velocidad2, Space.World);
        }

        else if (contador <= 0)
        {
            vectorVelocidad2 = vectorVelocidad2 * -1;
            contador = 1f;
        }
    }
}
