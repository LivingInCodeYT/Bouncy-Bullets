using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Effect : MonoBehaviour {

    void Update() {
        if (PlayerPrefs.GetInt("effectsEnabled", 1) == 0) {
            Destroy(gameObject);
        }
    }

}