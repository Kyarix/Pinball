
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    
    private Rigidbody _rb;

    //private float minX = -23f;
    //private float maxX = 7f;

    //private float minY = 1f;
    //private float maxY = 48f;

    //private float maxZ = -15.47f;
    //private int _puntos;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    

    private void Activar()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.useGravity = true;
        }
        
    }

    private void Update()
    {
        Activar();
        //LimitarPosicion();
    }

    //private void LimitarPosicion()
    //{
    //    Vector3 posicion = transform.position;

    //    posicion.x = Mathf.Clamp(posicion.x, minX, maxX);
    //    posicion.y = Mathf.Clamp(posicion.y, minY, maxY);
    //    posicion.z = Mathf.Clamp(posicion.z, float.MinValue, maxZ);

    //    transform.position = new Vector3(posicion.x, posicion.y, posicion.z);
    //}

    
}




