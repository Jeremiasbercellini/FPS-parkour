using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCaja : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
