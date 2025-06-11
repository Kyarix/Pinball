using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoMovimiento : MonoBehaviour
{
    [SerializeField] protected float fuerzaImpulso = 10f;
    [SerializeField] protected Pelota pelotaRef;
    [SerializeField] protected float velocidadRotacion = 5f;
    [SerializeField] protected float _direccionRotacion = 0f;


    protected Quaternion _inicialRotacion;
    protected KeyCode _entradaTeclado;
    protected bool _presionandoTecla;


    protected virtual void Start()
    {
        _inicialRotacion = transform.rotation;
    }

    protected virtual void ManejarInput()
    {
        _presionandoTecla = Input.GetKey(_entradaTeclado);
    }

    protected virtual void Mover()
    {
        if (_presionandoTecla)
        {

            transform.Rotate(0f, 0.0f, _direccionRotacion, Space.Self);

        }
        else if (!_presionandoTecla)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _inicialRotacion, velocidadRotacion);
        }

    }
   
    

    protected void Update()
    {
        ManejarInput();
        Mover();

    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == pelotaRef.gameObject && _presionandoTecla)
        {
            Rigidbody pelotaRb = pelotaRef.GetComponent<Rigidbody>();
            if (pelotaRb != null)
            {

                Vector3 direccionImpulso = new Vector3(-0.2f, 1f, 0f).normalized;
                pelotaRb.AddForce(direccionImpulso * fuerzaImpulso, ForceMode.Impulse);

                Debug.Log("Impulso");
            }
        }
        
    }

}
