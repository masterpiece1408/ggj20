using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class run : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("mainScene");
        
        }
    }
}
