using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour {
    private LevelLoader loader;

    void Awake() {
        loader = FindObjectOfType<LevelLoader>();
    }
    public void NextLevel() {
        StartCoroutine(loader.Fade(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void Menu() {
        StartCoroutine(loader.Fade(0));
    }
}