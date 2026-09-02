using System.Collections;

using UnityEngine;

public class SpawnerTest : MonoBehaviour

{

    public GameObject enemyPrefab;

    void Start()

    {

        Debug.Log("Startが呼ばれたよ！");

        StartCoroutine(SpawnLoop());

    }

    IEnumerator SpawnLoop()

    {

        while (true)

        {

            yield return new WaitForSeconds(2f);

            Debug.Log("2秒経ったよ！");

            if (enemyPrefab != null)

            {

                Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            }

        }

    }

}
