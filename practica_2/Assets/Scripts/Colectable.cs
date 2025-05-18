using UnityEngine;

public class colectable : MonoBehaviour
{
    private static int colisiones = 0;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisioné con: " + other.name);

        colisiones++;

        // Buscar el script Movement en el objeto que tiene el tag "Player"
        Movement movement = other.GetComponent<Movement>();

        if (movement != null && colisiones >= 10)
        {
            movement.cambiaOjeto = true;
            Debug.Log("¡Se han recolectado 10 objetos! CambiaOjeto = true");
        }

        Destroy(this.gameObject);
    }
}
