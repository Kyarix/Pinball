using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public static Puntuacion Instance;
    private int puntos;

    private void Awake()
    {
        Instance = this;
    }

    public void SumarPunto()
    {
        puntos++;
    }

    //public void MostrarPuntos()
    //{
    //    Debug.Log("Puntos: " + puntos);
    //}

    public void OnDestroy()
    {
        Debug.Log("Puntos: " + puntos);
    }
}
