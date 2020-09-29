using UnityEngine;

public class PowerupSpawner : MonoBehaviour {
	public GameObject[] powerups;
    public float spawnEvery = 15f;
    public float randomness = 3f;
    public int maxPowerupsInPlaySpace = 1;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Awake() {
        InvokeRepeating("Spawn", spawnEvery + Random.Range(-randomness, randomness), spawnEvery + Random.Range(-randomness, randomness));
    }
    void Spawn() {
        if (FindObjectOfType<GameManager>().gameIsOver) return;
        if (GameObject.FindGameObjectsWithTag("Powerup").Length < maxPowerupsInPlaySpace) {
            int rand = Random.Range(0, powerups.Length);
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            Vector2 pos = new Vector2(x, y);
            GameObject spawned = Instantiate(powerups[rand], pos, Quaternion.identity);
        } else {
            return;
        }
    }
}