using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCntrlNail : MonoBehaviour
{
    public GameObject obj;

    public bool check = false;
    void Start()
    {

    }

    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Animation nail = GetComponent<Animation>();
        nail.Play("nailDown");
        check = true; 
        Animation nextLevel = GetComponent<Animation>();
        nextLevel.Play("nextLevel");
    }
}
