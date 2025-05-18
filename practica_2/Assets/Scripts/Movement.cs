using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]// permite que la variable private aparesca en unity y sea modificable

    private float speed = 1f;
    public float HorizontalInput;// para mover de manera en x con solo las teclas a y d
    public float VerticalInput;// para mover de manera en y con solo las teclas w y s

    public GameObject bala;

    public GameObject bala_doble;

    public bool cambiaOjeto = false;

    void Start()
    {


    }
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");// te mueves en x
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        VerticalInput = Input.GetAxis("Vertical"); // te mueves en y 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        //Debug.Log(transform.position);

        // LIMITES DEL ESENARIO VERTICAL
        if (transform.position.z <= 8.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 8.1f);
        }
        if (transform.position.z >= 59f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 59f);
        }

        if (transform.position.x <= 8.64f)
        {
            transform.position = new Vector3(8.64f, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 21f)
        {
            transform.position = new Vector3(21f, transform.position.y, transform.position.z);
        }

        //instaciar un objeto
        //si la tecla espacio o cualquier otra es presionada
        //aparece el objeto o se debe instaciar

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(bala);//para disparar la bala cuando se aprieta espacio
            //Instantiate(bala, transform.position, Quaternion.identity);//se logra llevar la bala y que se dispare desde el lugar donde esta el personaje
            cambiaMiObjeto();
            //Instantiate(miObjeto);
            //Instantiate(miObjeto, transform.position, Quaternion.identity);

        }

    }
    private void cambiaMiObjeto()
    {
        if (cambiaOjeto == true)
        {
            //Instantiate(bala_doble, transform.position, Quaternion.identity);
            Instantiate(bala_doble, transform.position, transform.rotation);
        }
        else
        {
            //Instantiate(bala, transform.position, Quaternion.identity);
            Instantiate(bala, transform.position, transform.rotation);
        }
    }
}
