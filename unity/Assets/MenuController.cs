using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public Button play_button, quit_button;

    void Start() {
        play_button.onClick.AddListener(Play);
        quit_button.onClick.AddListener(Quit);
    }

    void Play() {
        SceneManager.LoadScene("scene", LoadSceneMode.Single);
    }

    void Quit() {
        Application.Quit();
    }
}
