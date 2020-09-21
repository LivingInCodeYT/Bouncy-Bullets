using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    private LevelLoader loader;

    void Start() {
        loader = FindObjectOfType<LevelLoader>();
    }
    public void LoadLevel(int index) {
        StartCoroutine(loader.Fade(index));
    }
    public void Quit() {
        Debug.Log("Quitting!");
        PlayerPrefs.Save();
        Application.Quit(0);
    }
}