using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCntrl : MonoBehaviour
{
    public GameObject obj;

    private animationCntrlNail animationCntrlNail;

    void Awake()
    {
        animationCntrlNail = GetComponent<animationCntrlNail>();
    }
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animation molot = GetComponent<Animation>();
            molot.Play("hitmolot");
        }
    }
}
