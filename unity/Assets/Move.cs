using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool grounded;
    Rigidbody2D rb;
    public float speed;
    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move_horizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(Mathf.Cos(GravityController.angle * (Mathf.PI / 180)) * move_horizontal,
                                       Mathf.Sin(GravityController.angle * (Mathf.PI / 180)) * move_horizontal);
        body.velocity += (movement * speed);

        if (isGrounded())
        {
            grounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            grounded = false;
        }
    }

    bool isGrounded()
    {

    }

}
