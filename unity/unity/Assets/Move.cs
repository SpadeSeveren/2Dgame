using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move_horizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(Mathf.Cos(GravityController.angle * (Mathf.PI/180))*move_horizontal, 
                                       Mathf.Sin(GravityController.angle * (Mathf.PI/180))*move_horizontal);
        body.velocity += (movement * speed);
    }
}
