using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool gameIsOver;
    public GameObject gameOverPanel;
    public GameObject winPanel;

    public void GameOver() {
        if (!gameIsOver) {
            gameIsOver = true;
            gameOverPanel.SetActive(true);
        }
    }
    public void WinLevel() {
        if (!gameIsOver) {
            gameIsOver = true;
            winPanel.SetActive(true);
        }
    }
}