using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIzq : ManejoMovimiento
{
    protected override void Start()
    {
        base.Start();
        _entradaTeclado = KeyCode.A;
        _direccionRotacion = 2f;
    }
    

}
