using UnityEngine;

public class KillAllBullets : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            DestroyAllBullets();
            Destroy(gameObject);
        }
    }
    void DestroyAllBullets() {
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("Bullet")) {
            Destroy(b);
        }
    }
}