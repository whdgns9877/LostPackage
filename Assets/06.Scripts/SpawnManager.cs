using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public bool isSpawn = true;
    float spawnTimer;
    public float spawnDelay = 1.5f;
    Vector3[] positions = new Vector3[5];
    // Use this for initialization
    void CreatePositions()
    {
        float viewPosY = 1.2f;
        float viewPosX = 0f;
        float gapX = 1f / 6f;
        for (int i = 0; i < positions.Length; i++)
        {
            viewPosX = gapX + gapX * i;
            Vector3 viewPos
                = new Vector3(viewPosX, viewPosY, 10);
            Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);
            worldPos.z = 0f;
            positions[i] = worldPos;
            print(worldPos);
        }
    }
    void Start()
    {
        CreatePositions();
    }
    void SpawnEnemy()
    {
        if (isSpawn == true)
        {
            if (spawnTimer > spawnDelay)
            {
                int rand = Random.Range(0, positions.Length);
                Instantiate(enemyPrefab, positions[rand]
                , Quaternion.identity);

                spawnTimer = 0f;
            }
            spawnTimer += Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
}
