using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Test_clase : MonoBehaviour
{
    //public float posx = 12.29f;
    //public float posy = 2.92f;
    //public float posz = 11.6f;

    public Transform player;
    void Start()
    {
       
        //Debug.Log("Helo world, Unity");// EN ESTE METODO SE EJECUTA SOLO UNA VEZ
        //Debug.Log("Mi nombre es: "+ name);//name da el nombre del objeto al que esta asociado este script, aqui sale "Mi nombre es Main camara" en la consola
        //Debug.Log("Mi posicion en x es :" + transform.position.x);
        //Debug.Log("Mi posicion en y es :" + transform.position.y);
        //Debug.Log("Mi posicion en z es :" + transform.position.z);
        //Debug.Log("Mi posicion en z es :" + transform.position);// da la pocision en x,y,z

        //transform.position = new Vector3(posx,posy,posz);//Ubica al objeto en la posición 0,0,0 en x,y,z


    }
    void Update()
    {
        //Debug.Log("Helo world, Unity");//HACE UN LOOP EN ESTE METODO DE MANERA QUE SE EJECUTA INDETERMINADA INDETERMINADAD MENTE
    }
    void LateUpdate()
    {
        if ( player != null) {
            transform.position = player.position;
        }

    }
}
