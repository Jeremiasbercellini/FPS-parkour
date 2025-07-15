using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoScript : MonoBehaviour
{
    public float daño = -10f;
    public VidaManager vidaManager;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vidaManager.UpdateLife(daño);
        }
    }

}
