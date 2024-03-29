using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField]
    GameObject ballPrefab;

    [SerializeField]
    GameObject bombPrefab;

    [Header("Bounds buffer")]
    [SerializeField]
    private float buffer = 50f;

    [Header("Collider settings")]
    [SerializeField]
    private float radius;

    [SerializeField]
    LayerMask mask;

    [Header("Difficult script reference")]
    [SerializeField]
    DifficultScript difficult;

    Collider2D[] colliders;
    private bool canSpawn = false;

    public void SpawnRandom()
    {
        Vector2 spawnPos = ReturnSpawnPosition();

        colliders = Physics2D.OverlapCircleAll(spawnPos, radius, mask);

        if (colliders.Length > 0)
        {
            canSpawn = false;
        }
        else
        {
            canSpawn = true;
        }

        if (canSpawn)
        {
            if (Random.value > 0.1)
            {
                Instantiate(ballPrefab, spawnPos, Quaternion.identity);
            }
            else
            {
                Instantiate(bombPrefab, spawnPos, Quaternion.identity);
            }
        }
    }

    private Vector2 ReturnSpawnPosition()
    {
        Vector3 worldMin = Camera.main.ScreenToWorldPoint(new Vector2(buffer, buffer));
        Vector3 worldMax = Camera.main.ScreenToWorldPoint(
            new Vector2(Screen.width - buffer, Screen.height - buffer)
        );
        Vector2 spawnPos = new Vector2(
            Random.Range(worldMin.x, worldMax.x),
            Random.Range(worldMin.y, worldMax.y)
        );
        return spawnPos;
    }

    public IEnumerator SpawnCircles()
    {
        while (true)
        {
            SpawnRandom();

            yield return new WaitForSeconds(difficult.GenerateDifficult());
        }
    }
}
