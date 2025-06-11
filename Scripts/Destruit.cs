using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruit : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Puntuacion.Instance.SumarPunto();
        Destroy(gameObject);
        
    }

    
}
