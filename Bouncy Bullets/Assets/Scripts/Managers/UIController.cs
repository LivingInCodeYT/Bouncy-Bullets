using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour {
	private GameManager gM;
	public TextMeshProUGUI timerText;

    void Start() {
        gM = GetComponent<GameManager>();
    }
    public void SetTimeToSurvive(int value) {
        if (value > 0) {
            if (!gM.gameIsOver) {
                timerText.text = (value.ToString());
            } else {
                timerText.text = ("0");
            }
        } else {
            gM.WinLevel();
        }
    }
    public string GetCurrentTimeToSurviveAsText() {
        return timerText.text;
    }
}