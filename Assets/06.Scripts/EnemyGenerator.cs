using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;

    GameObject[] existEnemys;

    public int maxEnemy;
    // Start is called before the first frame update
    void Start()
    {
        existEnemys = new GameObject[maxEnemy];
        StartCoroutine(Exec());      
    }

    IEnumerator Exec()
    {
        while(true){
            Generate();
            yield return new WaitForSeconds(10.0f);
        }
    }

    void  Generate()
    {
        for (int enemyCount = 0; enemyCount<existEnemys.Length; ++enemyCount)
        {
            if (existEnemys[enemyCount] == null)
            {
                existEnemys[enemyCount] = Instantiate(enemyPrefab, transform.position,
                    transform.rotation) as GameObject;
                return;
            }
        }
    }
}
