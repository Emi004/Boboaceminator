using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsSpawn : MonoBehaviour
{
    public GameObject clouds;
    private float spawnTime = 0;
    public float spawnRate;
    public float xOff = 2;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(clouds, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(clouds, new Vector3(transform.position.x + xOff, transform.position.y, 5), transform.rotation);
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
            spawnTime = 0;
            Instantiate(clouds, new Vector3(transform.position.x+xOff,transform.position.y,5), transform.rotation);
        
        }
    }
}
