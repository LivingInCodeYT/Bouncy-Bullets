using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour {
	public TextMeshProUGUI timerText;

    public void SetTimeToSurvive(int value) {
		if (value >= 0) {
			timerText.text = (value.ToString());
        }
	}
}