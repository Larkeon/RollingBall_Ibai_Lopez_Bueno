using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBolas : MonoBehaviour
{
    [SerializeField] GameObject bola;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bola, transform.position, Quaternion.identity);

        }
    }
}
