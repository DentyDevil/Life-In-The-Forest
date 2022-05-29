using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Enemy Configuration")]
    public static int spawnEmemyType = 1;
    public GameObject[] enemyPrefab;
    public float startWaveDuration;
    public static float waveDuration;

    [Header("Wave configuration")]
    public float waveRate = 1;
    public float spawnEmenyRate = 1;
    public int enemySpawnCount = 1;

    public GameOver gameOver;

    float countdown = 2;

    LevelWin levelWin;

    private void Start()
    {
        waveDuration = startWaveDuration;
        levelWin = GetComponent<LevelWin>();

    }

    private void Update()
    {
        if (levelWin.levelWin == true)
            return;

        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = waveRate;
            return;
        }
        countdown -= Time.deltaTime;
        waveDuration -= Time.deltaTime;
        waveDuration = Mathf.Clamp(waveDuration, 0, waveDuration);
        if (waveDuration == 0)
        {
            gameOver.gameEnd();
            waveDuration = startWaveDuration;
        }
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < enemySpawnCount; i++)
        {
            SpawnEnemy(-4f, 4);
            yield return new WaitForSeconds(1 / spawnEmenyRate);
        }
    }

    void SpawnEnemy(float bottomBound, float topBound)
    {
        float posY = Random.Range(bottomBound, topBound);
        Vector2 spawnPosY = new Vector2(20f, posY );
        int randomEnemy = Random.Range(0, spawnEmemyType);

        Instantiate(enemyPrefab[randomEnemy], spawnPosY, Quaternion.identity);
    }
}
