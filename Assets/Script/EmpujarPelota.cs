using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujarpelota : MonoBehaviour
{
    Animator anim;
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        EmpujarBola();
    }

    private void EmpujarBola()
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("Empujar", true);
        }
        if (!Input.GetKey(KeyCode.E))
        {
            anim.SetBool("Empujar", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
