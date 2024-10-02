using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    [SerializeField] float velocidad;
    Vector3 vectorRotation = new Vector3(1,0,0);
    float contador = 10f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        if(contador > 0)
        {
            contador -=  Time.deltaTime;
            transform.Translate (vectorRotation.normalized * velocidad);           
        }

        else if(contador <= 0)
        {
            velocidad = velocidad * -1;
            contador = 10f;
        }

        Debug.Log(contador);
    }
}
