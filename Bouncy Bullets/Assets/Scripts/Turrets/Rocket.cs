using UnityEngine;

public class Rocket : MonoBehaviour {
    private Rigidbody2D rb;
    private Transform target;

    public float turnSpeed = 2f;
    public float speed;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update() {
        rb.velocity = transform.up * speed;

        Look();
    }
    void Look() {
        Vector2 dir = target.position - transform.position;
        if ((Vector2)transform.up != dir) {
            transform.up = Vector2.MoveTowards(transform.up, dir, turnSpeed);
        }
    }
}