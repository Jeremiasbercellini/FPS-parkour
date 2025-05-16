using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartSceneOnFall : MonoBehaviour
{
    public float deathFallHeight = -7;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y < deathFallHeight)
        {
            Debug.Log("respown");
            SceneManager.LoadScene("FPS parkour");
        }
    }
}
