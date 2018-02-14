using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {
    public float angle = 0,
                 target_angle = 180;

	// Use this for initialization
	void Start () {
        target_angle = 180; 
	}
	
	// Update is called once per frame
	void Update () {
		angle += (target_angle - angle) * 0.5f;
	    Physics2D.gravity = new Vector2((float)Math.Cos((angle-90) * (Math.PI / 180.0))*100, (float)Math.Sin((angle-90) * (Math.PI / 180.0))*100);
    }
}
