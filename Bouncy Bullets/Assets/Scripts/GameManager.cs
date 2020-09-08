using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool gameIsOver; 
    public GameObject gameOverPanel;

    public void GameOver() {
        if (!gameIsOver) {
            gameIsOver = true;
            gameOverPanel.SetActive(true);
        }
    }
}