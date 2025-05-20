using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 3f;
    public float heightOffset = 3f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Spawnpipe), 1f, spawnRate);
    }

    void Spawnpipe(){
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPosition =new Vector3(transform.position.x, transform.position.y+randomHeight, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
    public void UpdateSpawnRate(){
        CancelInvoke(nameof(Spawnpipe));
        InvokeRepeating(nameof(Spawnpipe), spawnRate, spawnRate);
        Debug.Log(spawnRate);
    }
}
