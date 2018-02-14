using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cemera : MonoBehaviour
{
    public float angle = 0,
           target_angle = 180;

    // Use this for initialization
    void Start()
    {
        target_angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            target_angle += 90;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            target_angle -= 90;
        }


        angle += (target_angle - angle) * 0.1f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
