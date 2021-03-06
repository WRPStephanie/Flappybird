using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject column;
    public float colddown = 2f;
    float nextSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + colddown;
            Vector3 spawnP = transform.position;
            spawnP.y += Random.Range(-2f, 2f);
            Instantiate(column, spawnP, transform.rotation);
        }
        
    }
}
