using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour
{
    public int scorePoints;

    private void OnCollisionEnter(Collision collision)
    {
        if (Collision.gameObject.name == "player")
        {
            Destroy(gameObject);
            
        }
    }
    
}
