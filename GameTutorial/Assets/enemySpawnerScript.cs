using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemySequence());
    }

    IEnumerator spawnEnemySequence()
    {
        while (true)
        {
            float spawnLocation = Random.Range(-120, 98);
            Vector3 position = new Vector3(spawnLocation, 0, 126.6f);
            Instantiate(enemy, position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
