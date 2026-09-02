using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minSpawnTime = 2f;
    [SerializeField] private float maxSpawnTime = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            float randomTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(randomTime);

            if (GameObject.FindWithTag("Enemy") == null)
            {
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                Debug.Log("敵を生成したよ！");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
