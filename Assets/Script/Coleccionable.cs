using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] float velocidad;
    Vector3 vectorRotation = new Vector3(1,0,0);
    float contador = 50f;
    [SerializeField] float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador -=  tiempo * Time.deltaTime;
        if(contador > 0)
        {
            transform.Translate (vectorRotation * velocidad);
            
        }

        else if(contador <= 0)
        {
            velocidad = velocidad * -1;
            contador = 50f;
        } 
    }
}
