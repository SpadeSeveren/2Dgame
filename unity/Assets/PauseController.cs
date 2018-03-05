using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {
    public Button play_button, quit_button;

    void Start() {
        play_button.onClick.AddListener(Resume);
        quit_button.onClick.AddListener(Quit);
    }

    void Resume() {
        GameController.Resume();
    }

    void Quit() {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
}
