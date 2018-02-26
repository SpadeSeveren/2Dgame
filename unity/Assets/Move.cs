using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public float rayRange = 0.75f;
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

        Vector2 movement = new Vector2(Mathf.Cos(GravityController.angle * (Mathf.PI / 180)) * move_horizontal,
                                       Mathf.Sin(GravityController.angle * (Mathf.PI / 180)) * move_horizontal);
        body.velocity += (movement * speed);

        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            body.AddForce(new Vector2(Mathf.Cos((GravityController.angle + 90) * (Mathf.PI / 180)), Mathf.Sin((GravityController.angle + 90) * (Mathf.PI / 180))) * 50000,
                            ForceMode2D.Force);
        }
    }

    bool OnGround()
    {
        return (
            Physics2D.Raycast(
                body.position,
                new Vector2(Mathf.Cos((GravityController.angle - 90) * (Mathf.PI / 180)), Mathf.Sin((GravityController.angle - 90) * (Mathf.PI / 180))),
                rayRange,
                ~(LayerMask.GetMask("Player"))
            ).rigidbody != null

            ||
            
            Physics2D.Raycast(
                body.position,
                new Vector2(Mathf.Cos(GravityController.angle * (Mathf.PI / 180)), Mathf.Sin(GravityController.angle * (Mathf.PI / 180))),
                rayRange,
                ~(LayerMask.GetMask("Player"))
            ).rigidbody != null
        );
    }

}
