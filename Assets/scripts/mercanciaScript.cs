using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour
{
    public int precio = -10;
    public DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dineroManager.UpdateMoney(precio);
            Destroy(gameObject);
        }
    }
    
}
