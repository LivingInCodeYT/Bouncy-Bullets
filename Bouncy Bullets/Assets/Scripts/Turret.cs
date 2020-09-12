using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Turret : MonoBehaviour {
    private AudioSource source;
    private Transform target;
    private Vector2 dir;
    private float rotZ;

    public GameObject bullet;
    public float range = 1f;
    public float bulletSpeed;
    public float fireEvery = 2f;
    public float random = 5f;
    public float seekEvery = 0.5f;
    public float offset = 90f;

    void Start() {
        source = GetComponent<AudioSource>();
        InvokeRepeating("Seek", 0f, seekEvery);
        InvokeRepeating("Shoot", fireEvery, fireEvery + Random.Range(-random, random));
    }
    void Update() {
        Aim();
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
    void Seek() {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Player")) {
            if (Vector2.Distance(transform.position, g.transform.position) < range) {
                target = g.transform;
            } else {
                target = null;
            }
        }
    }
    void Aim() {
        //  Dont aim if there is no target
        if (target == null) return;
        dir = transform.position - target.position;
        rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    }
    void Shoot() {
        //  Dont shoot if there is no target
        if (target == null) return;
        GameObject b = Instantiate(bullet, transform.position, transform.rotation);
        b.GetComponent<Rigidbody2D>().velocity = (-dir * bulletSpeed);
        source.Play();
        FindObjectOfType<CameraScript>().Shake(1);
    }   
}