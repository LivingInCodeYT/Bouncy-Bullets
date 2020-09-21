using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {
    private LevelLoader loader;

    void Awake() {
        loader = FindObjectOfType<LevelLoader>();
    }
    public void RestartLevel() {
        StartCoroutine(loader.Fade(SceneManager.GetActiveScene().buildIndex));
    }
    public void Menu() {
        StartCoroutine(loader.Fade(0));
    }
}