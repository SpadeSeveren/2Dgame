using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cemera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    { 
        transform.rotation = Quaternion.AngleAxis(GravityController.angle, Vector3.forward);
    }
}
