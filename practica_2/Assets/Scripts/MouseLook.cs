using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 1000000f;
    public Transform playerBody; // El objeto del personaje (padre de la cámara)

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Oculta el cursor y lo bloquea
    }

    void Update()
    {
        // Solo rotar cámara si se mantiene presionado el botón derecho del mouse
        if (Input.GetMouseButton(0)) // 1 = botón izquierdo
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limita la rotación vertical

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Rotación vertical (cámara)
            playerBody.Rotate(Vector3.up * mouseX); // Rotación horizontal (personaje)
        }
    }
}
