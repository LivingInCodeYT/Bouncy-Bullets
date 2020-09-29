using UnityEngine;
using TMPro;

public class StartTimer : MonoBehaviour {
    private TextMeshProUGUI timerText;
    private int time = 3;

    void Awake() {
        FindObjectOfType<GameManager>().gameIsOver = true;
        timerText = GameObject.FindGameObjectWithTag(Tags.StartTimer).GetComponent<TextMeshProUGUI>();
        timerText.text = "3";
        InvokeRepeating("DecreaseTime", 1f, 1f);
    }
    void DecreaseTime() {
        if (time == 1) {
            FindObjectOfType<GameManager>().gameIsOver = false;
            CancelInvoke("DecreaseTime");
            timerText.gameObject.SetActive(false);
            return;
        } else {
            time--;
            timerText.text = time.ToString();
        }
    }
}