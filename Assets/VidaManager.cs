using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaManager : MonoBehaviour
{
    public float life;

    public void UpdateLife(float damage)
    {


        if (life - damage < 0)
        {
            SceneManager.LoadScene("FPS parkour");
        }
        else
        {
            life -= damage;
        }

    }
}
