using UnityEngine;

public class KillAllBullets : MonoBehaviour {
    public float rotSpeed = 5f;
    public GameObject collectEffect;

    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 0f, 90f), rotSpeed);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            DestroyAllBullets();
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void DestroyAllBullets() {
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("Bullet")) {
            Destroy(b);
        }
    }
}