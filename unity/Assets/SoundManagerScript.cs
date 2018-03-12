using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip death;
    static AudioSource audioSrc;
    void Start()
    {
        death = Resources.Load<AudioClip>("game_over");
        audioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {

    }

    public static void PlayerSound(string clip)
    {
        print("OOF");
        switch (clip)
        {
            case "game_over":
                audioSrc.PlayOneShot(death);
                break;
        }
    }
}
