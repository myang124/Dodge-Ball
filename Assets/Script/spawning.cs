using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject red;
    public float randx;
    Vector2 position;
    float nextSpawn = 0.0f;
    public float spawnTimer;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnTimer;
            randx = Random.Range(-3f, 3f);
            position = new Vector2(randx, 5);
            Instantiate(red, position, Quaternion.identity);
        }
    }
}
