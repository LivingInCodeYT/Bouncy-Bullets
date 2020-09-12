using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    private LevelLoader loader;

    void Start() {
        loader = FindObjectOfType<LevelLoader>();
    }
    public void PlayGame() {
        StartCoroutine(loader.Fade(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void Quit() {
        PlayerPrefs.Save();
        Application.Quit(0);
    }
}