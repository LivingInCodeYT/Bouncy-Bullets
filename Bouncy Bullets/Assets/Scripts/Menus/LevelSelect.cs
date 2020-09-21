using UnityEngine;
using TMPro;

public enum Difficulty {
    Normal,
    Hard
}
public class LevelSelect : MonoBehaviour {
    public Difficulty dif;
    public TextMeshProUGUI difText;
    [Header("Panels")]
    public GameObject normalModePanel;
    public GameObject hardModePanel;

    public void ChangeDifficulty() {
        if (dif == Difficulty.Normal) {
            normalModePanel.SetActive(false);
            hardModePanel.SetActive(true);
            dif = Difficulty.Hard;
            difText.text = "Hard";
        } else {
            normalModePanel.SetActive(true);
            hardModePanel.SetActive(false);
            dif = Difficulty.Normal;
            difText.text = "Normal";
        }
    }
}