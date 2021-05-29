using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaclepattern;

    private float timeBtwSpawn;
    public float startTimeBtwspawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclepattern.Length);
            Instantiate(obstaclepattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwspawn;
            if (startTimeBtwspawn > minTime)
            {
                startTimeBtwspawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;   
        }
    }
}
