using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject BgPrefab;
    public float spawnRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawnbg), 1f, spawnRate);
    }

    // Update is called once per frame
    void Spawnbg()
    {
        Vector3 spawnPosition = new Vector3(22, transform.position.y, 0);
        Instantiate(BgPrefab, spawnPosition, Quaternion.identity);
    }
}
