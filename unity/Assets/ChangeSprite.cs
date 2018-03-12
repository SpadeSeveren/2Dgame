using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ChangeSprite : MonoBehaviour
{

    public Sprite upR;
    public Sprite leftR;
    public Sprite rightR;
    public Sprite downR;
    public Sprite upL;
    public Sprite leftL;
    public Sprite rightL;
    public Sprite downL;

    private string[] dir;
    private string[] face;
    private int dirPos;
    private int fPos;



    private SpriteRenderer spriteRenderer;

    void Start()
    {
        dirPos = 0;
        dir = new string[4] { "up", "right", "down", "left" };
        face = new string[2] { "left", "right" };
        spriteRenderer = GetComponent<SpriteRenderer>();
        fPos = 1;
    }

    void Update()
    {
        ChangeTheDamnSprite(dir[dirPos], face[fPos]);
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            fPos = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            fPos = 1;
        }
    }

    void ChangeTheDamnSprite(string d, string f)
    {
        if (f == "left")
        {
            if (d == "up")
            {
                spriteRenderer.sprite = upL;
            }
            else if (d == "right")
            {
                spriteRenderer.sprite = rightL;
            }
            else if (d == "down")
            {
                spriteRenderer.sprite = downL;
            }
            else if (d == "left")
            {
                spriteRenderer.sprite = leftL;
            }
        }
        else if (f == "right")
        {
            if (d == "up")
            {
                spriteRenderer.sprite = upR;
            }
            else if (d == "right")
            {
                spriteRenderer.sprite = rightR;
            }
            else if (d == "down")
            {
                spriteRenderer.sprite = downR;
            }
            else if (d == "left")
            {
                spriteRenderer.sprite = leftR;
            }
        }
    }
}
