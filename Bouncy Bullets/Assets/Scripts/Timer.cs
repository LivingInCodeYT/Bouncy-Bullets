using UnityEngine;

public class Timer : MonoBehaviour {
    private float oneSecond = 1f;
    private int timeToSurvive;
	private UIController uiController;

    public int timeToWin;

    void Awake() {
        timeToSurvive = timeToWin;
        uiController = GetComponent<UIController>();
        uiController.SetTimeToSurvive(timeToSurvive);
    }
    void Update() {
        if (oneSecond <= 0f) {
            timeToSurvive--;
            oneSecond = 1f;
            uiController.SetTimeToSurvive(timeToSurvive);
        } else {
            oneSecond -= Time.deltaTime;
        }
    }
}