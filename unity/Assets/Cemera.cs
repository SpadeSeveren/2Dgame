using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cemera : MonoBehaviour
{
    public Rigidbody2D player;
    private Vector3 offset;

    void Start() {
        offset = transform.position - player.transform.position; 
    }

    // Update is called once per frame
    void Update() {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.AngleAxis(GameController.angle, Vector3.forward);
    }
}
