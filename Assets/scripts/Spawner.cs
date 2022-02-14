using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -5.5f)
        {
            Vector2 spawnPoint = new Vector2(Random.Range(-8.35f, 8.35f), 5.5f);
            transform.position = new Vector3(spawnPoint.x, spawnPoint.y, 0.0f);
        }
           
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 spawnPoint = new Vector2(Random.Range(-8.35f, 8.35f), 5.5f);
        transform.position = new Vector3(spawnPoint.x, spawnPoint.y, 0.0f);
    }
}
