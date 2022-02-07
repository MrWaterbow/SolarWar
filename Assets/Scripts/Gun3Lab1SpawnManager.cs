using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun3Lab1SpawnManager : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject spawnManager;
    private IEnumerator inst = null;
    public GameObject player;

    void Start()
    {
        InvokeRepeating("StartEnemyCorotine", 0, 7.0f);
    }

    private void EnemyWin()
    {
       if (Gun3Lab1.gameOff == true)
       {
            CancelInvoke("StartEnemyCorotine");
       }
    }

    private void StartEnemyCorotine()
    {
        StartCoroutine("SpawnEnemy1");
        StartCoroutine("SpawnEnemy2");
        StartCoroutine("SpawnEnemy3");
        StartCoroutine("SpawnEnemy4");
        StartCoroutine("SpawnEnemy5");
        StartCoroutine("SpawnEnemy6");
        StartCoroutine("SpawnEnemy7");
        StartCoroutine("SpawnEnemy8");
        StartCoroutine("SpawnEnemy9");
        StartCoroutine("SpawnEnemy10");
        StartCoroutine("SpawnEnemy11");
        StartCoroutine("SpawnEnemy12");
        StartCoroutine("SpawnEnemy13");
    }

    public void StopSpawnEnemy()
    {
        StopCoroutine(SpawnEnemy1());
    }

    private IEnumerator SpawnEnemy1()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject enemyClone1 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f,61.0f,0), spawnManager.transform.rotation);
        enemyClone1.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone1.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(1.8f);
        enemyClone1.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone1.AddComponent<CircleCollider2D>().radius = 0.2f;
        
    }
    private IEnumerator SpawnEnemy2() 
    {
        yield return new WaitForSeconds(0.6f);
        GameObject enemyClone2 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone2.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone2.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(1.5f);
        enemyClone2.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone2.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy3()
    {
        yield return new WaitForSeconds(0.9f);
        GameObject enemyClone3 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone3.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone3.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(1.2f);
        enemyClone3.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone3.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy4()
    {
        yield return new WaitForSeconds(1.2f);
        GameObject enemyClone4 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone4.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone4.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(0.9f);
        enemyClone4.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone4.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy5()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject enemyClone5 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone5.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone5.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(0.6f);
        enemyClone5.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone5.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy6()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject enemyClone6 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone6.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone6.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(1.8f);
        enemyClone6.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone6.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy7()
    {
        yield return new WaitForSeconds(0.6f);
        GameObject enemyClone7 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone7.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone7.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(1.5f);
        enemyClone7.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone7.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy8()
    {
        yield return new WaitForSeconds(0.9f);
        GameObject enemyClone8 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone8.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone8.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(1.2f);
        enemyClone8.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone8.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy9()
    {
        yield return new WaitForSeconds(1.2f);
        GameObject enemyClone9 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone9.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone9.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(0.9f);
        enemyClone9.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone9.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy10()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject enemyClone10 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone10.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone10.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(0.6f);
        enemyClone10.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone10.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy11()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject enemyClone11 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(-1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone11.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone11.GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        yield return new WaitForSeconds(0.3f);
        enemyClone11.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone11.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy12()
    {
        yield return new WaitForSeconds(1.8f);
        GameObject enemyClone12 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone12.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone12.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(0.3f);
        enemyClone12.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone12.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    private IEnumerator SpawnEnemy13()
    {
        yield return new WaitForSeconds(2.1f);
        GameObject enemyClone13 = Instantiate(enemies[Random.Range(0, enemies.Count)], new Vector3(1.5f, 61.0f, 0), spawnManager.transform.rotation);
        enemyClone13.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
        yield return new WaitForSeconds(0.4f);
        enemyClone13.GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        yield return new WaitForSeconds(0);
        enemyClone13.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enemyClone13.AddComponent<CircleCollider2D>().radius = 0.2f;
    }

    void Update()
    {
        EnemyWin();
    }
}
