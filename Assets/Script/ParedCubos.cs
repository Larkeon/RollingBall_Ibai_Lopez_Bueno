using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    float tiempo = 2f;
    bool iniciarTimer;
    [SerializeField] Rigidbody[] rbs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iniciarTimer)
        {
            tiempo -= Time.unscaledDeltaTime;
            if (tiempo <= 0)
            {
                
                Time.timeScale = 1;
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
                tiempo = 2f;
                iniciarTimer = false;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarTimer = true;

        }
    }
}
