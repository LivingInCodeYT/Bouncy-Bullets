using UnityEngine;

public class Effect : MonoBehaviour {

    void Start() {
        if (PlayerPrefs.GetInt("effectsEnabled", 1) == 0) {
            Destroy(gameObject);
        }
    }
}