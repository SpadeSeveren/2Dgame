using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{

    public Sprite up;
    public Sprite left;
    public Sprite right;
    public Sprite down;

    private string[] dir;
    private int dirPos;



    private SpriteRenderer spriteRenderer;

    void Start()
    {
        dirPos = 0;
        dir = new string[4] { "up", "right", "down", "left" };
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        ChangeTheDamnSprite(dir[dirPos]);
        if (Input.GetKeyDown(KeyCode.E))
        {
            dirPos++;
            if (dirPos == 4)
            {
                dirPos = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            dirPos--;
            if (dirPos == -1)
            {
                dirPos = 3;
            }
        }
    }

    void ChangeTheDamnSprite(string d)
    {
        if (d == "up")
        {
            spriteRenderer.sprite = up;
        }
        else if (d == "right")
        {
            spriteRenderer.sprite = right;
        }
        else if (d == "down")
        {
            spriteRenderer.sprite = down;
        }
        else if (d == "left")
        {
            spriteRenderer.sprite = left;
        }
    }
}
