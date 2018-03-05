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
    void FixedUpdate()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        
        float x_vel = body.velocity.x,
              y_vel = body.velocity.y,
              move_angle = GameController.angle * (Mathf.PI / 180);

        x_vel += (move_horizontal*Mathf.Cos(move_angle));
        y_vel += (move_horizontal*Mathf.Sin(move_angle));

        body.velocity = new Vector2(x_vel, y_vel);

        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            body.AddForce(new Vector2(Mathf.Cos((GameController.angle + 90) * (Mathf.PI / 180)), Mathf.Sin((GameController.angle + 90) * (Mathf.PI / 180))) * 15,
                            ForceMode2D.Impulse);
        }
    }

    bool OnGround()
    {
        return (
            Physics2D.Raycast(
                body.position,
                new Vector2(Mathf.Cos((GameController.angle - 90) * (Mathf.PI / 180)), Mathf.Sin((GameController.angle - 90) * (Mathf.PI / 180))), rayRange,
                ~(LayerMask.GetMask("Player"))
            ).rigidbody != null

            ||
            
            Physics2D.Raycast(
                body.position,
                new Vector2(Mathf.Cos(GameController.angle * (Mathf.PI / 180)), Mathf.Sin(GameController.angle * (Mathf.PI / 180))), rayRange,
                ~(LayerMask.GetMask("Player"))
            ).rigidbody != null
        );
    }

}
