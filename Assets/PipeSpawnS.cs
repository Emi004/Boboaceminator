using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class PipeSpawnS : MonoBehaviour
{
    public GameObject pipe;
    private float spawnTime=0;
    public float spawnRate;
    public float heigthOff = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = randomSpawnRate();

        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime = spawnTime + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTime = 0;
            spawnRate =randomSpawnRate();
        }

    }

    void spawnPipe() 
    {
        float lowpoint = transform.position.y - heigthOff;
        float highpoint = transform.position.y + heigthOff;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowpoint, highpoint), 0), transform.rotation);
    }
    float randomSpawnRate() 
    {
        return (float) Random.Range(2, 6);
    }
}
