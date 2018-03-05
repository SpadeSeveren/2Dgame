using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    static public int score = 0;
    static public bool paused = false;
    static public float angle = 0,
                        target_angle = 180;

    public GameObject pause_canvas;
    public Text score_text;

    public static void Pause() {
        paused = true;
    }

    public static void Resume() {
        paused = false;
    }

    // Use this for initialization
    void Start()
    {
        target_angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score: " + score;

        Time.timeScale = paused ? 0 : 1; 
        
        if(Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            target_angle += 90;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            target_angle -= 90;
        }

        pause_canvas.SetActive(paused);
    }

    void FixedUpdate() {
        angle += (target_angle - angle) * 0.1f;
        if (angle >= 359)
        {
            angle -= 360;
            target_angle -= 360;
        }
        if (angle <= -89)
        {
            angle += 360;
            target_angle += 360;
        }
        Physics2D.gravity = new Vector2((float)Math.Cos((angle - 90) * (Math.PI / 180.0)), (float)Math.Sin((angle - 90) * (Math.PI / 180.0))) * 50;

    }
}
