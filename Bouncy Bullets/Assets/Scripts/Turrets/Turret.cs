using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Turret : MonoBehaviour {
    #region Random Private Variables
    private AudioSource source;
    private Transform target;
    private Vector2 dir;
    private float rotZ;
    #endregion
    #region Other Variables
    [Header("Shooting")]
    public GameObject bullet;
    public float range = 1f;
    public float bulletSpeed;
    public float fireEvery = 2f;
    public float random = 5f;
    public float seekEvery = 0.5f;
    public float offset = 90f;
    [Header("Movement")]
    public bool shouldMove;
    public Vector2[] points;
    public float speed = 1f;
    private int index;
    #endregion

    #region Unity Methods
    void Start() {
        source = GetComponent<AudioSource>();
        InvokeRepeating("Seek", 0f, seekEvery);
        InvokeRepeating("Shoot", fireEvery, fireEvery + Random.Range(-random, random))  ;
    }
    void Update() {
        Aim();
        if (shouldMove)
            Move();
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.green;
        for (int i = 0; i < points.Length - 1; i++) {
            Gizmos.DrawLine(points[i], points[i + 1]);
        }
    }
    #endregion
    #region Methods
    void Seek() {
        Transform p = GameObject.FindGameObjectWithTag(Tags.Player).transform;
        if (Vector2.Distance(transform.position, p.position) < range) {
            target = p;
        } else {
            target = null;
        }
    }
    void Aim() {
        //  DONT AIM IF THE PLAYER IS NOT IN RANGE
        if (target == null) return;

        dir = transform.position - target.position;
        rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    }
    void Shoot() {
        //  DONT SHOOT IF THE PLAYER IS NOT IN RANGE
        //  DONT SHOOT IF THE GAME IS CURRENTLY OVER
        if (target == null) return;
        if (FindObjectOfType<GameManager>().gameIsOver) return;

        GameObject b = Instantiate(bullet, transform.position, transform.rotation);
        b.GetComponent<Rigidbody2D>().velocity = (-dir * bulletSpeed);
        source.Play();
        FindObjectOfType<CameraScript>().Shake(1);
    }
    void Move() {
        transform.position = Vector2.MoveTowards(transform.position, points[index], speed);

        if (transform.position.x == points[index].x && transform.position.y == points[index].y)
            index++;
        if (index == points.Length)
            index = 0;
    }
    #endregion
}