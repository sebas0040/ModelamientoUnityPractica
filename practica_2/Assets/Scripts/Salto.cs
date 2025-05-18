using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoConSalto : MonoBehaviour
{
    public float speed = 5f;
    public float fuerzaSalto = 5f;
    private Rigidbody rb;

    private bool enElSuelo = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // Salto
        if (Input.GetKeyDown(KeyCode.Q) && enElSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enElSuelo = false;
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo")) 
        {
            enElSuelo = true;
        }
    }
}

