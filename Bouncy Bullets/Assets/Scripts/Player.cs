using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    private GameManager gM;
    private Rigidbody2D rb;
    private Vector3 movement;

	public float moveSpeed = 5f;
    [Header("Boundaries")]
    public float minX, maxX;
    public float minY, maxY;

    void Awake() {
        gM = GameObject.FindGameObjectWithTag(Tags.Manager).GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
        if (!gM.gameIsOver) {
            movement = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, Input.GetAxisRaw("Vertical") * moveSpeed, 0f);
        } else {
            movement = Vector3.zero;
        }
    }
    void FixedUpdate() {
        if (!gM.gameIsOver) {
            rb.MovePosition(transform.position + movement);
            #region Rotation
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                transform.rotation = Quaternion.Euler(0f, 0f, -90f);
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            #endregion
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag(Tags.Bullet))
            gM.GameOver();
    }
}