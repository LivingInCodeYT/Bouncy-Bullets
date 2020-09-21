using UnityEngine;

public class Bullet : MonoBehaviour {
    public float delay = 100f;

    void Start() {
        Destroy(gameObject, delay);
    }
}