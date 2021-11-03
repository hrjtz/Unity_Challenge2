using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -18;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private int spawnBallLow = 0;
    private int spawnBallHigh = 3;

    private float startDelay = 1.0f;
    private float spawnIntervalLow = 3.0f;
    private float spawnIntervalHigh = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(spawnIntervalLow, spawnIntervalHigh));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(spawnBallLow, spawnBallHigh)], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
