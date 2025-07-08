using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoScript : MonoBehaviour
{
    public float daño = -10f;
    public VidaManager vidaManager;

    public void Start()
    {
        Debug.Log("existooo o!!11!1!");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit!!!!!");
            vidaManager.UpdateLife(daño);
        }
        else
        {
            Debug.Log("NOT Player!!11!1!");
        }
    }

}
