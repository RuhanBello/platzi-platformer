using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    public GameObject metalBallPrefab;

    public float intervalBetweenSpawns;

    private float spawnTimer;

    private void Start() {
        spawnTimer = intervalBetweenSpawns;
    }

    // Update is called once per frame
    void Update() {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0) {
            spawnTimer = intervalBetweenSpawns;
            Instantiate(metalBallPrefab, transform.position + Vector3.up, metalBallPrefab.transform.rotation);
        }
    }
}
