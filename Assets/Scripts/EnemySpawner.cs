using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minSpawnTime = 10f;
    [SerializeField] private float maxSpawnTime = 20f;

    public GameObject EnemyPrefab;
    public int currentEnemyHP = 2;

    public void SpawnEnemy()
    {
        if (enemyPrefab != null)
        {
            GameObject newEnemyObj = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            Enemy newEnemy = newEnemyObj.GetComponent<Enemy>();
            if (newEnemy != null)
            {
                newEnemy.maxHp = currentEnemyHP;
                newEnemy.hp = currentEnemyHP;

                newEnemy.UpdateHPUI();
            }
        }
    }

    public void IncreaseNextEnemyHP()
    {
        int randomAdd = Random.Range(2, 4);
        currentEnemyHP *= randomAdd;
        Debug.Log($"次の敵のHPが{currentEnemyHP}に強化された");
    }

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
