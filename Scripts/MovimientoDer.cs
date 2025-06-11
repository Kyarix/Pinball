using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDer : ManejoMovimiento
{
    protected override void Start()
    {
        base.Start();
        _entradaTeclado = KeyCode.D;
        _direccionRotacion = -2f;
    }
}
