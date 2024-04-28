using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpd=2f;
    public float deletePos = -41;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position+ (Vector3.left * moveSpd)*Time.deltaTime;
        if (transform.position.x < deletePos)
        {
            Destroy(gameObject);
        }
    }
}
