using UnityEngine;

public class PreformanceCount : MonoBehaviour {
    private float deltaTime;
    private float fps;

    void Update() {
        deltaTime += Time.deltaTime;
        deltaTime /= 2f;
        fps = 1f / deltaTime;
        Debug.Log("CURRENT FPS: " + fps.ToString());
    }

}