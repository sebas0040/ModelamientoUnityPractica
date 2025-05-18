using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_doble : MonoBehaviour
{
    public float speed1 = 5f;
    public float maxTravelDistance = 20f;

    private Vector3 startPosition;

    void Start()
    {
        // Guarda la posición inicial al instanciar la bala
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed1 * Time.deltaTime);

        float distanceTraveled = Vector3.Distance(startPosition, transform.position);
        if (distanceTraveled > maxTravelDistance)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject); // Destruye el obstáculo
            Destroy(this.gameObject);  // Destruye el proyectil
        }
    }
}

