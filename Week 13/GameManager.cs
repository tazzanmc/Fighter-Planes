using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject coinPrefab;
    public GameObject shieldPowerupPrefab;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 1, 1);
        InvokeRepeating("CreateCoin", 6, 6);
        InvokeRepeating("CreateShieldPowerup", 1, 15);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateCoin()
    {
        Instantiate(coinPrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-3.5f, 0f), 0), Quaternion.identity);
    }

    void CreateShieldPowerup()
    {
        Instantiate(shieldPowerupPrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-3.5f, 0f), 0), Quaternion.identity);
    }
}
