using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class KillAllBullets : MonoBehaviour {
    private AudioSource source;
    public float speed = 50f;

    void Start() {
        source = GetComponent<AudioSource>();
    }
    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 0f, 90f), speed);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            source.Play();
            Debug.Log("Played");
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