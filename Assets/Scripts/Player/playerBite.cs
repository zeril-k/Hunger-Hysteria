using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBite : MonoBehaviour
{
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.Play("playerBite");
    }
}
